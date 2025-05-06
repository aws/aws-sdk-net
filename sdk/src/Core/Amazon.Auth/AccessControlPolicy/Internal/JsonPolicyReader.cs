/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Amazon.Auth.AccessControlPolicy.Internal
{
    /// <summary>
    /// Deserializes a JSON string into a AWS policy object.
    /// </summary>
    internal static class JsonPolicyReader
    {
        public static Policy ReadJsonStringToPolicy(string jsonString)
        {
            Policy policy = new Policy();
            using JsonDocument doc = JsonDocument.Parse(jsonString);
            JsonElement jPolicy = doc.RootElement;

            if (jPolicy.TryGetProperty(JsonDocumentFields.POLICY_ID, out JsonElement policyElement) && policyElement.ValueKind == JsonValueKind.String)
            {
                policy.Id = policyElement.GetString();
            }

            if (jPolicy.TryGetProperty(JsonDocumentFields.STATEMENT, out JsonElement jStatements) && jStatements.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement jStatement in jStatements.EnumerateArray())
                {
                    Statement statement = convertStatement(jStatement);
                    if (statement != null)
                    {
                        policy.Statements.Add(statement);
                    }
                }
            }
            return policy;
        }

        private static Statement convertStatement(JsonElement jStatement)
        {
            if (jStatement.TryGetProperty(JsonDocumentFields.STATEMENT_EFFECT, out JsonElement jEffect) && jEffect.ValueKind == JsonValueKind.String)
            {
                string jEffectValue = jEffect.GetString();
                Statement.StatementEffect effect;
                if (JsonDocumentFields.EFFECT_VALUE_ALLOW.Equals(jEffectValue))
                    effect = Statement.StatementEffect.Allow;
                else
                    effect = Statement.StatementEffect.Deny;

                Statement statement = new Statement(effect);

                if (jStatement.TryGetProperty(JsonDocumentFields.STATEMENT_ID, out JsonElement statementId) && statementId.ValueKind == JsonValueKind.String)
                    statement.Id = statementId.GetString();

                convertActions(statement, jStatement);
                convertResources(statement, jStatement);
                convertCondition(statement, jStatement);
                convertPrincipals(statement, jStatement);
                return statement;
            }
            else
            {
                return null;
            }
        }

        private static void convertPrincipals(Statement statement, JsonElement jStatement)
        {
            if (jStatement.TryGetProperty(JsonDocumentFields.PRINCIPAL, out JsonElement jPrincipals))
            {
                // if the principal's value is a string and not an object then it can only be "*".
                // do not try to enumerate the object and return.
                if (jPrincipals.ValueKind == JsonValueKind.String)
                {
                    if (jPrincipals.GetString().Equals("*"))
                    {
                        statement.Principals.Add(Principal.Anonymous);
                        return;
                    }
                }

                foreach (JsonProperty jPrincipal in jPrincipals.EnumerateObject())
                {
                    if (jPrincipal.Value.ValueKind == JsonValueKind.String)
                    {
                        // Don't strip '-' and assume the policy being deserialized is already valid.
                        Principal principal = new Principal(jPrincipal.Name, jPrincipal.Value.GetString());
                        statement.Principals.Add(principal);
                    }
                    else if (jPrincipal.Value.ValueKind == JsonValueKind.Array)
                    {
                        foreach (JsonElement arrayElement in jPrincipal.Value.EnumerateArray())
                        {
                            if (arrayElement.ValueKind == JsonValueKind.String)
                            {
                                // Don't strip '-' and assume the policy being deserialized is already valid.
                                Principal principal = new Principal(jPrincipal.Name, arrayElement.GetString(), false);
                                statement.Principals.Add(principal);
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private static void convertActions(Statement statement, JsonElement jStatement)
        {
            if (jStatement.TryGetProperty(JsonDocumentFields.ACTION, out JsonElement jActionsElement))
            {
                if (jActionsElement.ValueKind == JsonValueKind.String)
                {
                    statement.Actions.Add(new ActionIdentifier(jActionsElement.GetString()));
                }
                else if (jActionsElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (JsonElement jActionValue in jActionsElement.EnumerateArray())
                    {
                        if (jActionValue.ValueKind == JsonValueKind.String)
                        {
                            statement.Actions.Add(new ActionIdentifier(jActionValue.GetString()));
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private static void convertResources(Statement statement, JsonElement jStatement)
        {
            if (jStatement.TryGetProperty(JsonDocumentFields.RESOURCE, out JsonElement jResourceElement))
            {
                if (jResourceElement.ValueKind == JsonValueKind.String)
                {
                    statement.Resources.Add(new Resource(jResourceElement.GetString()));
                }
                else if (jResourceElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (JsonElement jResourceValue in jResourceElement.EnumerateArray())
                    {
                        if (jResourceValue.ValueKind == JsonValueKind.String)
                        {
                            statement.Resources.Add(new Resource(jResourceValue.GetString()));
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private static void convertCondition(Statement statement, JsonElement jStatement)
        {
            if (jStatement.TryGetProperty(JsonDocumentFields.CONDITION, out JsonElement jCondition))
            {
                foreach (JsonProperty jConditionProperty in jCondition.EnumerateObject())
                {
                    string type = jConditionProperty.Name;
                    JsonElement comparisons = jConditionProperty.Value;
                    foreach (JsonProperty jComparison in comparisons.EnumerateObject())
                    {
                        string key = jComparison.Name;
                        List<string> values = new List<string>();
                        if (jComparison.Value.ValueKind == JsonValueKind.String)
                        {
                            values.Add(jComparison.Value.GetString());
                        }
                        else if (jComparison.Value.ValueKind == JsonValueKind.Array)
                        {
                            foreach (JsonElement jValue in jComparison.Value.EnumerateArray())
                            {
                                if (jValue.ValueKind == JsonValueKind.String)
                                {
                                    values.Add(jValue.GetString());
                                }
                            }
                        }
                        Condition condition = new Condition(type, key, values.ToArray());
                        statement.Conditions.Add(condition);
                    }
                }
            }
        }
    }
}

