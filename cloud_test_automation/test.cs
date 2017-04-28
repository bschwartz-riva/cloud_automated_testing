using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum account {trial, lite, standard, premium, none, all};
    public enum user {adminWithSync, adminWithoutSync, standard, none, all};
    public enum mode {single, company, corporate, none, all};
    public enum email {gmail, googleApps, exchange, notes, none, all};
    public enum CRM {dynamics, salesforce, sugar, oracle, sage, 1crm, netsuite, c4c, none, all};

    public class test
    {
        int runs;
        int successes;
        int failures;
        bool isCritical;
        account[] accounts;
        user[] users;
        mode[] modes;
        email[] emails;
        CRM[] CRMs;

	    public test(isCritical = false; accounts = {account.none}; users = {user.none}, modes = {mode.none}, emails = {email.none}; CRMs = {CRM.none}) {
            runs = 0;
            successes = 0;
            failures = 0;
            isCritical = false;
            this.accounts = accounts;
            this.users = users;
            this.modes = modes;
            this.emails = emails;
            this.CRMs = CRMs;
	    }

        run() {
            this.runs++;
            //check prerequisites
            //implement code
            //verify passed, and increment pass/fail counter
            //write out to logfile
        }
}
