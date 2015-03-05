using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class PolicyTests
    {
        [TestMethod]
        public void TestIfStatementAlreadyExists()
        {
            var policy = new Policy();

            Statement statement = new Statement(Statement.StatementEffect.Allow);
            statement.Actions.Add(SQSActionIdentifiers.SendMessage);
            statement.Resources.Add(new Resource("the:queue:arn"));
            statement.Conditions.Add(ConditionFactory.NewSourceArnCondition("source:arn"));
            statement.Principals.Add(new Principal("*"));

            policy.Statements.Add(statement);

            Statement newStatement = new Statement(Statement.StatementEffect.Allow);
            newStatement.Actions.Add(SQSActionIdentifiers.SendMessage);
            newStatement.Resources.Add(new Resource("the:queue:arn"));
            newStatement.Conditions.Add(ConditionFactory.NewSourceArnCondition("source:arn"));
            newStatement.Principals.Add(new Principal("*"));

            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Effect = Statement.StatementEffect.Deny;
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Effect = Statement.StatementEffect.Allow;
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Actions.Add(SQSActionIdentifiers.AddPermission);
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Actions.Remove(SQSActionIdentifiers.AddPermission);
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Principals.Add(new Principal("data"));
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));

            newStatement.Principals.RemoveAt(1);
            Assert.IsTrue(policy.CheckIfStatementExists(newStatement));

            newStatement.Conditions[0].ConditionKey = "new:arn";
            Assert.IsFalse(policy.CheckIfStatementExists(newStatement));
        }
    }
}
