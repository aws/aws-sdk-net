using System.Collections.Generic;
using System.Linq;
using Amazon.Auth.AccessControlPolicy;
using Xunit;

namespace UnitTests.NetStandard.Core.Auth
{
    public class PolicySerializationTests
    {
        [Fact]
        public void AllUserPrinciple()
        {
            var policy = new Policy();
            policy.Statements.Add(new Statement(Statement.StatementEffect.Allow)
            {
                Principals = new List<Principal> { new Principal("*") },
            });
            var roundTrippedPolicy = Policy.FromJson(policy.ToJson());

            var roundTrippedPrincipal = roundTrippedPolicy.Statements.ElementAt(0).Principals.ElementAt(0);

            Assert.Equal(Principal.AllUsers.Id, roundTrippedPrincipal.Id);
            Assert.Equal(Principal.AllUsers.Provider, roundTrippedPrincipal.Provider);
        }

        [Fact]
        public void AnonymousPrinciple()
        {
            var policy = new Policy();
            policy.Statements.Add(new Statement(Statement.StatementEffect.Allow)
            {
                Principals = new List<Principal> { Principal.Anonymous },
            });
            var roundTrippedPolicy = Policy.FromJson(policy.ToJson());

            var roundTrippedPrincipal = roundTrippedPolicy.Statements.ElementAt(0).Principals.ElementAt(0);

            Assert.Equal(Principal.Anonymous.Id, roundTrippedPrincipal.Id);
            Assert.Equal(Principal.Anonymous.Provider, roundTrippedPrincipal.Provider);
        }

        [Fact]
        public void MultiplePrinciples()
        {
            var policy = new Policy();
            policy.Statements.Add(new Statement(Statement.StatementEffect.Allow)
            {
                Principals = new List<Principal>
                {
                    new Principal("arn:aws:iam::123456789012:root"),
                    new Principal("arn:aws:iam::123456789014:user"),
                },
            });
            var roundTrippedPolicy = Policy.FromJson(policy.ToJson());

            var roundTrippedPrincipal1 = roundTrippedPolicy.Statements.ElementAt(0).Principals.ElementAt(0);
            var roundTrippedPrincipal2 = roundTrippedPolicy.Statements.ElementAt(0).Principals.ElementAt(1);

            Assert.Equal("arn:aws:iam::123456789012:root", roundTrippedPrincipal1.Id);
            Assert.Equal(Principal.AllUsers.Provider, roundTrippedPrincipal1.Provider);
            Assert.Equal("arn:aws:iam::123456789014:user", roundTrippedPrincipal2.Id);
            Assert.Equal(Principal.AllUsers.Provider, roundTrippedPrincipal2.Provider);
        }
    }
}