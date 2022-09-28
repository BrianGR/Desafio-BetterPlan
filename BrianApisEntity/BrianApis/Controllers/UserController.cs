
namespace BrianApis.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using BrianApis.Context;
    using BrianApis.Models;
    using System;
    using System.Text.Json;
    using System.IO;
    using System.Xml.Linq;
    using System.Text.Json.Serialization;
    using System.Security.Claims;
    using Newtonsoft.Json;
    using System.Collections;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private CompanyContext _companyContext;

        public UserController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _companyContext.Users;
        }


        [HttpGet("{id}")]
        public UserResponse1 Get(int id)
        {
            UserResponse1 usuario = new UserResponse1();
            try
            {
                User user1 = new User();
                User user2 = new User();

                user1 = _companyContext.Users.FirstOrDefault(s => s.id == id);

                if (user1.advisorid != null)
                {
                    user2 = _companyContext.Users.FirstOrDefault(s => s.id == user1.advisorid);
                }
                if (user1 != null && user2 != null)
                {
                    usuario.id = Convert.ToInt32(user1.id);
                    usuario.nombreCompleto = user1.firstname + " " + user1.surname;
                    usuario.nombreCompletoAdvisor = user2.firstname + " " + user2.surname;
                    usuario.fechaCreacion = user1.created;
                }

                return usuario;
            }
            catch (ExecutionEngineException ex)
            {
                return usuario;
            }

        }


        [HttpGet("{id}/summary")]
        public UsersResponse2 GetSummary(int id)
        {
            UsersResponse2 summary = new UsersResponse2();

            try
            {
                User user1 = new User();

                user1 = _companyContext.Users.FirstOrDefault(s => s.id == id);

                if (user1 != null)
                {
  
                    var query = from u in _companyContext.Users
                                join gtf in _companyContext.GoalTransactionFunding
                                on u.id equals gtf.ownerid
                                join cr in _companyContext.Currency
                                on u.currencyid equals cr.id
                                join ci in _companyContext.CurrencyIndicator
                                on cr.id equals ci.id
                                join f in _companyContext.Funding
                                on gtf.fundingid equals f.id
                                join fsv in _companyContext.FundingShareValue
                                on f.id equals fsv.fundingid
                                join gt in _companyContext.GoalTransaction
                                on gtf.transactionid equals gt.id
                                where u.id == id

                                select new
                                {
                                    balance = ((gtf.quotas) * (fsv.value) * (ci.value)),
                                    aportes = ((gt.amount) * (ci.value))
                                };

           

                    if (query != null)
                    {
                    
                        var balance = query.Sum(x => x.balance);
                        var aportes = query.Sum(x => x.aportes);

                        summary.balance = balance;
                        summary.aportesActuales = aportes;
                    }

                }

                return summary;
            }
            catch (ExecutionEngineException ex)
            {
                return summary;
            }

        }

        [HttpGet("{id}/summary/{fecha}")]
        public UsersResponse3 GetSummaryDate(int id, string fecha)
        {
            UsersResponse3 summary = new UsersResponse3();

            try
            {
                User user1 = new User();

                user1 = _companyContext.Users.FirstOrDefault(s => s.id == id);
                DateTime date = Convert.ToDateTime(fecha);
                if (user1 != null)
                {

                    var query = from u in _companyContext.Users
                                join gtf in _companyContext.GoalTransactionFunding
                                on u.id equals gtf.ownerid
                                join cr in _companyContext.Currency
                                on u.currencyid equals cr.id
                                join ci in _companyContext.CurrencyIndicator
                                on cr.id equals ci.id
                                join f in _companyContext.Funding
                                on gtf.fundingid equals f.id
                                join fsv in _companyContext.FundingShareValue
                                on f.id equals fsv.fundingid
                                join gt in _companyContext.GoalTransaction
                                on gtf.transactionid equals gt.id
                                where u.id == id && fsv.date == date

                                select new
                                {
                                    balance = ((gtf.quotas) * (fsv.value) * (ci.value)),
                                    aportes = ((gt.amount) * (ci.value))
                                };

                    if (query != null)
                    {

                        var balance = query.Sum(x => x.balance);
                        var aportes = query.Sum(x => x.aportes);

                        summary.balance = balance;
                        summary.aportesActuales = aportes;
                    }

                }

                return summary;
            }
            catch (ExecutionEngineException ex)
            {
                return summary;
            }

        }

        [HttpGet("{id}/goals")]
        public IEnumerable<UsersResponse4> GetSummaryGoals(int id)
        {
            UsersResponse4 user = new UsersResponse4();
            Response4List summary = new Response4List();
            string json = "";
            List<UsersResponse4> lista = null;
            try
            {
                User user1 = new User();

                user1 = _companyContext.Users.FirstOrDefault(s => s.id == id);



                var query = from u in _companyContext.Users
                            join goal in _companyContext.Goals
                            on u.id equals goal.userid
                            join gtf in _companyContext.GoalTransactionFunding
                            on u.id equals gtf.ownerid
                            join fe in _companyContext.FinancialEntity
                            on goal.financialentityid equals fe.id
                            join port in _companyContext.Portafolio
                            on goal.portfolioid equals port.id
                            join rl in _companyContext.RiskLevel
                            on port.risklevelid equals rl.id
                            join inv in _companyContext.InvestmentStrategy
                            on port.investmentstrategyid equals inv.id
                            where u.id == id

                            select new
                            {
                                tituloMeta = goal.title,
                                años = goal.years,
                                inversionInicial = goal.initialinvestment,
                                aporteMensual = goal.monthlycontribution,
                                montoObjetivo = goal.targetamount,
                                entidadFinanciera = fe.title,
                                portafolioTitle = port.title,
                                portafolioUuid = port.uuid,
                                portafolioDes = port.description,
                                portafolioMaxyear = port.maxrangeyear,
                                portafolioMinyear = port.minrangeyear,
                                fechaCreacion = port.created,
                                fechaModificacion = port.modified,
                                nivelRiesgo = rl.title,
                                isDefault = port.isdefault,
                                investmentStrategyid = inv.title,
                                version = port.version,
                                extraProfitabilityCurrencyCode = port.extraprofitabilitycurrencycode,
                                estimatedProfitability = port.estimatedprofitability,
                                bpcomission = port.bpcomission
                            };

                if (query != null)
                {

                    //string json = JsonSerializer.Serialize(query);

                    json = JsonConvert.SerializeObject(query);
                    lista = JsonConvert.DeserializeObject<List<UsersResponse4>>(json);
                }
                return lista;

            }
            catch (ExecutionEngineException ex)
            {
                return lista;
            }


        }
        

        [HttpGet("{id}/goals/{idgoal}")]
        public IEnumerable<UsersResponse5> GetSummaryGoalsId(int id, int idgoal)
        {

            string json = "";
            List<UsersResponse5> lista = null;
            try
            {
                User user1 = new User();

                user1 = _companyContext.Users.FirstOrDefault(s => s.id == id);



                var query = from u in _companyContext.Users
                            join goal in _companyContext.Goals
                            on u.id equals goal.userid
                            join gtf in _companyContext.GoalTransactionFunding
                            on u.id equals gtf.ownerid
                            join gt in _companyContext.GoalTransaction
                            on gtf.transactionid equals gt.id
                            join fe in _companyContext.FinancialEntity
                            on goal.financialentityid equals fe.id
                            join port in _companyContext.Portafolio
                            on goal.portfolioid equals port.id
                            join rl in _companyContext.RiskLevel
                            on port.risklevelid equals rl.id
                            join inv in _companyContext.InvestmentStrategy
                            on port.investmentstrategyid equals inv.id
                            join cr in _companyContext.Currency
                            on u.currencyid equals cr.id
                            join ci in _companyContext.CurrencyIndicator
                            on cr.id equals ci.id
                            join f in _companyContext.Funding
                            on gtf.fundingid equals f.id
                            join fsv in _companyContext.FundingShareValue
                            on f.id equals fsv.fundingid
                            /*join pcom in _companyContext.PortafolioComposition
                            on port.id equals pcom.portfolioid*/

                            where u.id == id && goal.id == idgoal

                            select new
                            {
                                tituloMeta = goal.title,
                                años = goal.years,
                                inversionInicial = goal.initialinvestment,
                                aporteMensual = goal.monthlycontribution,
                                montoObjetivo = goal.targetamount,
                                entidadFinanciera = fe.title,
                                portafolioTitle = port.title,
                                portafolioUuid = port.uuid,
                                portafolioDes = port.description,
                                portafolioMaxyear = port.maxrangeyear,
                                portafolioMinyear = port.minrangeyear,
                                fechaCreacion = port.created,
                                fechaModificacion = port.modified,
                                nivelRiesgo = rl.title,
                                isDefault = port.isdefault,
                                investmentStrategyid = inv.id,
                                version = port.version,
                                extraProfitabilityCurrencyCode = port.extraprofitabilitycurrencycode,
                                estimatedProfitability = port.estimatedprofitability,
                                bpcomission = port.bpcomission,
                                totalAportes = ((gt.amount) * (ci.value)),
                                totalRetiros = gt.cost,
                                //porCumplimientoMeta = pcom.porcentage
                            };

                if (query != null)
                {

                    //string json = JsonSerializer.Serialize(query);

                    json = JsonConvert.SerializeObject(query);
                    lista = JsonConvert.DeserializeObject<List<UsersResponse5>>(json);
                }
                return lista;

            }
            catch (ExecutionEngineException ex)
            {
                return lista;
            }


        }

    }
}
