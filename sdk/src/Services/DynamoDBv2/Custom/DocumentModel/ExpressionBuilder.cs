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

/*
 * This file contains classes and utilities for building expressions used in DynamoDB operations.
 * It provides a flexible and extensible framework for constructing conditional, filter, and query expressions
 * using attribute names, values, and logical operators.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Amazon.Runtime;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Interface for building expressions used in DynamoDB operations.
    /// </summary>
    public interface IExpressionBuilder
    {
        /// <summary>
        /// Builds the expression based on the conditions and operands provided.
        /// </summary>
        /// <returns>An <see cref="Expression"/> object representing the constructed expression.</returns>
        Expression Build();
    }

    /// <summary>
    /// Abstract base class for building expressions used in DynamoDB operations.
    /// Provides a structure for managing conditions and operands that form the basis of an expression.
    /// </summary>
    public abstract class ExpressionBuilder: IExpressionBuilder
    {
        /// <summary>
        /// Builds the expression based on provided.
        /// </summary>
        /// <returns>An <see cref="Expression"/> object representing the constructed expression.</returns>
        public Expression Build()
        {
            var expressionTree = BuildExpressionTree(out string expressionType);

            var aliasList = new KeyAttributeAliasList();

            var expression = new Expression()
            {
                ExpressionStatement = expressionTree.BuildExpressionString(aliasList, expressionType)
            };

            if (aliasList.NamesList != null && aliasList.NamesList.Count != 0)
            {
                var namesDictionary = new Dictionary<string, string>();
                for (int i = 0; i < aliasList.NamesList.Count; i++)
                {
                    namesDictionary[$"#{expressionType}{i}"] = aliasList.NamesList[i];
                }

                expression.ExpressionAttributeNames = namesDictionary;
            }

            if (aliasList.ValuesList != null && aliasList.ValuesList.Count != 0)
            {
                var values = new Dictionary<string, DynamoDBEntry>();
                for (int i = 0; i < aliasList.ValuesList.Count; i++)
                {
                    values[$":{expressionType}{i}"] = aliasList.ValuesList[i];
                }

                expression.ExpressionAttributeValues = values;
            }

            return expression;
        }

        /// <summary>
        /// Builds the expression tree for the current expression builder. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal abstract ExpressionNode BuildExpressionTree(out string s);
    }

    /// <summary>
    /// The <see cref="UpdateExpressionBuilder"/> class is used to construct update expressions for DynamoDB operations.
    /// An update expression consists of one or more clauses. Each clause begins with a SET, REMOVE, ADD, or DELETE keyword. 
    /// You can include any of these clauses in an update expression, in any order.
    /// </summary>
    public class UpdateExpressionBuilder : ExpressionBuilder
    {

        private const string OperationModeSet = "SET";
        private const string OperationModeRemove = "REMOVE";
        private const string OperationModeAdd = "ADD";
        private const string OperationModeDelete = "DELETE";

        /// <summary>
        /// The list of operations that will be used in the update expression.
        /// </summary>
        private Dictionary<string,List<OperationBuilder>> OperationBuilders { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExpressionBuilder"/> class with default settings.
        /// </summary>
        protected UpdateExpressionBuilder()
        {
            OperationBuilders = new Dictionary<string, List<OperationBuilder>>();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="UpdateExpressionBuilder"/> class.
        /// </summary>
        /// <returns>A new <see cref="UpdateExpressionBuilder"/> instance for building update expressions.</returns>
        public static UpdateExpressionBuilder New()
        {
            return new UpdateExpressionBuilder();
        }

        /// <summary>
        /// Adds a "SET" operation to the update expression, which sets the value of an attribute.
        /// </summary>
        /// <param name="nameBuilder">The <see cref="NameBuilder"/> representing the attribute name.</param>
        /// <param name="setExpressionBuilder">The <see cref="SetValueBuilder"/> representing the value to set.</param>
        /// <returns>The current <see cref="UpdateExpressionBuilder"/> instance for chaining additional operations.</returns>
        public UpdateExpressionBuilder Set(NameBuilder nameBuilder, OperandBuilder setExpressionBuilder)
        {
            if (!OperationBuilders.TryGetValue(OperationModeSet, out var ops))
            {
                ops = new List<OperationBuilder>();
                OperationBuilders[OperationModeSet] = ops;
            }

            ops.Add(new OperationBuilder(OperationMode.Set)
            {
                Name = nameBuilder,
                Value = setExpressionBuilder
            });

            return this;
        }
        
        /// <summary>
        /// Adds a "REMOVE" operation to the update expression, which removes one or more attributes from an item.
        /// </summary>
        /// <param name="nameBuilder">The <see cref="NameBuilder"/> representing the attribute name to remove.</param>
        /// <returns>The current <see cref="UpdateExpressionBuilder"/> instance for chaining additional operations.</returns>
        public UpdateExpressionBuilder Remove(NameBuilder nameBuilder)
        {
            if (!OperationBuilders.TryGetValue(OperationModeRemove, out var ops))
            {
                ops = new List<OperationBuilder>();
                OperationBuilders[OperationModeRemove] = ops;
            }

            ops.Add(new OperationBuilder(OperationMode.Remove)
            {
                Name = nameBuilder
            });

            return this;
        }

        /// <summary>
        /// Adds a "DELETE" operation to the update expression, which removes one or more elements from a set attribute.
        /// </summary>
        /// <param name="nameBuilder">The <see cref="NameBuilder"/> representing the attribute name.</param>
        /// <param name="valueBuilder">The <see cref="ValueBuilder"/> representing the value to delete from the set.</param>
        /// <returns>The current <see cref="UpdateExpressionBuilder"/> instance for chaining additional operations.</returns>
        public UpdateExpressionBuilder Delete(NameBuilder nameBuilder, ValueBuilder valueBuilder)
        {
            if (!OperationBuilders.TryGetValue(OperationModeDelete, out var ops))
            {
                ops = new List<OperationBuilder>();
                OperationBuilders[OperationModeDelete] = ops;
            }

            ops.Add(new OperationBuilder(OperationMode.Delete)
            {
                Name = nameBuilder,
                Value = valueBuilder
            });

            return this;
        }

        /// <summary>
        /// Adds an "ADD" operation to the update expression, which adds a new attribute or modifies an existing one.
        /// If the attribute is a number, the value is added or subtracted. If the attribute is a set, the value is appended.
        /// </summary>
        /// <param name="nameBuilder">The <see cref="NameBuilder"/> representing the attribute name.</param>
        /// <param name="valueBuilder">The <see cref="ValueBuilder"/> representing the value to add.</param>
        /// <returns>The current <see cref="UpdateExpressionBuilder"/> instance for chaining additional operations.</returns>
        public UpdateExpressionBuilder Add(NameBuilder nameBuilder, ValueBuilder valueBuilder)
        {
            if (!OperationBuilders.TryGetValue(OperationModeAdd, out var ops))
            {
                ops = new List<OperationBuilder>();
                OperationBuilders[OperationModeAdd] = ops;
            }

            ops.Add(new OperationBuilder(OperationMode.Add)
            {
                Name = nameBuilder,
                Value = valueBuilder
            });

            return this;
        }

        /// <summary>
        /// Builds the expression tree for the update expression based on the operations provided.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>An <see cref="ExpressionNode"/> representing the constructed update expression tree.</returns>
        /// <exception cref="InvalidOperationException">Thrown if no operations are defined in the update expression.</exception>
        internal override ExpressionNode BuildExpressionTree(out string s)
        {
            s = "U";
            var resultNode = new ExpressionNode
            {
                Children = new Queue<ExpressionNode>()
            };

            if (OperationBuilders.TryGetValue(OperationModeSet, out var setOps))
            {
                var childNode = BuildChildNodes(setOps);
                resultNode.Children.Enqueue(childNode);
                resultNode.FormatedExpression += $"{OperationModeSet} #c\n";
            }

            if (OperationBuilders.TryGetValue(OperationModeRemove, out var removeOps))
            {
                var childNode = BuildChildNodes(removeOps);
                resultNode.Children.Enqueue(childNode);
                resultNode.FormatedExpression += $"{OperationModeRemove} #c\n";
            }

            if (OperationBuilders.TryGetValue(OperationModeAdd, out var addOps))
            {
                var childNode = BuildChildNodes(addOps);
                resultNode.Children.Enqueue(childNode);
                resultNode.FormatedExpression += $"{OperationModeAdd} #c\n";
            }

            if (OperationBuilders.TryGetValue(OperationModeDelete, out var deleteOps))
            {
                var childNode = BuildChildNodes(deleteOps);
                resultNode.Children.Enqueue(childNode);
                resultNode.FormatedExpression += $"{OperationModeDelete} #c\n";
            }

            if (resultNode.Children.Count == 0)
            {
                throw new InvalidOperationException("Cannot build update expression tree: operation list is empty.");
            }

            return resultNode;
        }

        private ExpressionNode BuildChildNodes(List<OperationBuilder> builders)
        {
            if (builders == null || builders.Count == 0)
            {
                throw new InvalidOperationException("Cannot build update expression tree: operation list is empty.");
            }

            var node = new ExpressionNode
            {
                Children = new Queue<ExpressionNode>()
            };

            foreach (var builder in builders)
            {
                var expr = builder.Build();

                node.Children.Enqueue(expr);
                node.FormatedExpression += "#c, ";
            }

            // Remove trailing comma and space, if any
            if (node.FormatedExpression.EndsWith(", "))
            {
                node.FormatedExpression = node.FormatedExpression.Substring(0, node.FormatedExpression.Length - 2);
            }

            return node;
        }

    }

    /// <summary>
    /// Class for building conditions used in DynamoDB expressions.
    /// Supports comparison, logical, and function-based conditions.
    /// </summary>
    public class ConditionExpressionBuilder : ExpressionBuilder
    {
        private readonly ConditionMode _conditionMode;

        /// <summary>
        /// The list of conditions that will be used in the expression.
        /// </summary>
        internal List<ExpressionBuilder> Conditions { get; set; }

        /// <summary>
        /// The list of operands that will be used in the expression.
        /// </summary>
        internal List<OperandBuilder> Operands { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionExpressionBuilder"/> class with default settings.
        /// </summary>
        protected ConditionExpressionBuilder()
        {
            _conditionMode = ConditionMode.Unset;
            Operands = new List<OperandBuilder>();
            Conditions = new List<ExpressionBuilder>();
        }

        private ConditionExpressionBuilder(List<OperandBuilder> operandBuilders, ConditionMode mode) : this()
        {

            _conditionMode = mode;
            Operands = operandBuilders;
        }

        private ConditionExpressionBuilder(List<ExpressionBuilder> conditionBuilders, ConditionMode mode) : this()
        {
            _conditionMode = mode;
            Conditions = conditionBuilders;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionExpressionBuilder"/>.
        /// </summary>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance.</returns>
        public static ConditionExpressionBuilder New()
        {
            return new ConditionExpressionBuilder();
        }

        /// <summary>
        /// Adds a condition to the current condition builder.
        /// </summary>
        /// <param name="condition">The condition to add.</param>
        /// <returns>The current <see cref="ConditionExpressionBuilder"/> instance for chaining.</returns>
        public ConditionExpressionBuilder WithCondition(ConditionExpressionBuilder condition)
        {
            Conditions.Add(condition);
            return this;
        }

        /// <summary>
        /// Adds an attribute name to the condition.
        /// </summary>
        /// <param name="path">The attribute name or path.</param>
        /// <returns>A <see cref="NameBuilder"/> for further configuration.</returns>
        public NameBuilder WithName(string path)
        {
            return new NameBuilder(path);
        }

        /// <summary>
        /// Combines multiple conditions using the logical "AND" operator.
        /// </summary>
        /// <param name="left">The first <see cref="ConditionExpressionBuilder"/> instance to combine.</param>
        /// <param name="right">The second <see cref="ConditionExpressionBuilder"/> instance to combine.</param>
        /// <param name="others">Additional <see cref="ConditionExpressionBuilder"/> instances to include in the combination.</param>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the combined "AND" condition.</returns>
        public static ConditionExpressionBuilder And(ConditionExpressionBuilder left, ConditionExpressionBuilder right,
            params ConditionExpressionBuilder[] others)
        {
            var allConditions = new List<ExpressionBuilder> { left, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionExpressionBuilder(allConditions, ConditionMode.And);
        }

        /// <summary>
        /// Combines the current condition with additional conditions using the logical "AND" operator.
        /// </summary>
        /// <param name="right">The <see cref="ConditionExpressionBuilder"/> instance to combine with the current condition.</param>
        /// <param name="others">Additional <see cref="ConditionExpressionBuilder"/> instances to include in the combination.</param>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the combined "AND" condition.</returns>
        public ConditionExpressionBuilder And(ConditionExpressionBuilder right, params ConditionExpressionBuilder[] others)
        {
            var allConditions = new List<ExpressionBuilder> { this, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionExpressionBuilder(allConditions, ConditionMode.And);
        }

        /// <summary>
        /// Combines multiple conditions using the logical "OR" operator.
        /// </summary>
        /// <param name="left">The first <see cref="ConditionExpressionBuilder"/> instance to combine.</param>
        /// <param name="right">The second <see cref="ConditionExpressionBuilder"/> instance to combine.</param>
        /// <param name="others">Additional <see cref="ConditionExpressionBuilder"/> instances to include in the combination.</param>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the combined "OR" condition.</returns>
        public static ConditionExpressionBuilder Or(ConditionExpressionBuilder left, ConditionExpressionBuilder right,
            params ConditionExpressionBuilder[] others)
        {
            var allConditions = new List<ExpressionBuilder> { left, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionExpressionBuilder(allConditions, ConditionMode.Or);
        }

        /// <summary>
        /// Combines the current condition with additional conditions using the logical "OR" operator.
        /// </summary>
        /// <param name="right">The <see cref="ConditionExpressionBuilder"/> instance to combine with the current condition.</param>
        /// <param name="others">Additional <see cref="ConditionExpressionBuilder"/> instances to include in the combination.</param>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the combined "OR" condition.</returns>
        public ConditionExpressionBuilder Or(ConditionExpressionBuilder right, params ConditionExpressionBuilder[] others)
        {
            var allConditions = new List<ExpressionBuilder> { this, right };
            if (others is { Length: > 0 })
            {
                allConditions.AddRange(others);
            }

            return new ConditionExpressionBuilder(allConditions, ConditionMode.Or);
        }

        /// <summary>
        /// Negates a condition using the logical "NOT" operator.
        /// </summary>
        /// <param name="condition">The <see cref="ConditionExpressionBuilder"/> instance to negate.</param>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the negated condition.</returns>
        public static ConditionExpressionBuilder Not(ConditionExpressionBuilder condition)
        {
            var allConditions = new List<ExpressionBuilder> { condition };
            return new ConditionExpressionBuilder(allConditions, ConditionMode.Not);
        }

        /// <summary>
        /// Negates the current condition using the logical "NOT" operator.
        /// </summary>
        /// <returns>A new <see cref="ConditionExpressionBuilder"/> instance representing the negated condition.</returns>
        public ConditionExpressionBuilder Not()
        {
            var allConditions = new List<ExpressionBuilder> { this };
            return new ConditionExpressionBuilder(allConditions, ConditionMode.Not);
        }

        internal static ConditionExpressionBuilder Equal(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.Equal);
            return condition;
        }

        internal static ConditionExpressionBuilder NotEqual(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.NotEqual);
            return condition;
        }

        internal static ConditionExpressionBuilder LessThan(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.LessThan);
            return condition;
        }

        internal static ConditionExpressionBuilder LessThanOrEqual(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.LessThanOrEqual);
            return condition;
        }

        internal static ConditionExpressionBuilder GreaterThan(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.GreaterThan);
            return condition;
        }

        internal static ConditionExpressionBuilder GreaterThanOrEqual(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.GreaterThanOrEqual);
            return condition;
        }

        internal static ConditionExpressionBuilder Between(OperandBuilder left, OperandBuilder lowerOperand, OperandBuilder upperOperand)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, lowerOperand, upperOperand }, ConditionMode.Between);
            return condition;
        }

        internal static ConditionExpressionBuilder In(OperandBuilder left, OperandBuilder rightOperand, params OperandBuilder[] otherOperands)
        {
            var operands = new List<OperandBuilder> { left, rightOperand };
            if (otherOperands is { Length: > 0 })
            {
                operands.AddRange(otherOperands);
            }
            var condition = new ConditionExpressionBuilder(operands, ConditionMode.In);
            return condition;
        }

        internal static ConditionExpressionBuilder AttributeExists(OperandBuilder nameOperand)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { nameOperand }, ConditionMode.AttributeExists);
            return condition;
        }

        internal static ConditionExpressionBuilder AttributeNotExists(OperandBuilder nameOperand)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { nameOperand }, ConditionMode.AttributeNotExists);
            return condition;
        }
        internal static ConditionExpressionBuilder AttributeType(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.AttributeType);
            return condition;
        }

        internal static ConditionExpressionBuilder Contains(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.Contains);
            return condition;
        }

        internal static ConditionExpressionBuilder BeginsWith(OperandBuilder left, OperandBuilder right)
        {
            var condition = new ConditionExpressionBuilder(new List<OperandBuilder> { left, right }, ConditionMode.BeginsWith);
            return condition;
        }

        /// <param name="s"></param>
        /// <inheritdoc/>
        internal override ExpressionNode BuildExpressionTree(out string s)
        {
            s = "C";
            var childNodes = BuildChildNodes();

            var node = new ExpressionNode
            {
                Children = childNodes,
            };

            return _conditionMode switch
            {
                ConditionMode.Equal or
                    ConditionMode.NotEqual or
                    ConditionMode.LessThan or
                    ConditionMode.LessThanOrEqual or
                    ConditionMode.GreaterThan or
                    ConditionMode.GreaterThanOrEqual =>
                    CompareBuildCondition(_conditionMode, node),

                ConditionMode.And or ConditionMode.Or =>
                    CompoundBuildCondition(this, node),

                ConditionMode.Not =>
                    NotBuildCondition(node),

                ConditionMode.Between =>
                    BetweenBuildCondition(node),

                ConditionMode.In =>
                    InBuildCondition(this, node),

                ConditionMode.AttributeExists =>
                    AttributeExistsBuildCondition(node),

                ConditionMode.AttributeNotExists =>
                    AttributeNotExistsBuildCondition(node),

                ConditionMode.AttributeType =>
                    AttributeTypeBuildCondition(node),

                ConditionMode.BeginsWith =>
                    BeginsWithBuildCondition(node),

                ConditionMode.Contains =>
                    ContainsBuildCondition(node),

                ConditionMode.Unset =>
                    throw new InvalidOperationException("ConditionBuilder"),

                _ =>
                    throw new InvalidOperationException($"Build condition error: unsupported mode: {_conditionMode}")
            };
        }

        private Queue<ExpressionNode> BuildChildNodes()
        {
            var childNodes = new Queue<ExpressionNode>();

            foreach (var condition in Conditions)
            {
                ExpressionNode node;
                try
                {
                    node = condition.BuildExpressionTree(out _);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to build condition tree", ex);
                }

                childNodes.Enqueue(node);
            }

            foreach (var operand in Operands)
            {
                ExpressionNode node;
                try
                {
                    node = operand.Build();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to build operand", ex);
                }

                childNodes.Enqueue(node);
            }

            return childNodes;
        }

        #region statement_build

        private ExpressionNode NotBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.Not;
            return node;
        }

        private ExpressionNode CompoundBuildCondition(ConditionExpressionBuilder conditionBuilder, ExpressionNode node)
        {
            var mode = conditionBuilder._conditionMode switch
            {
                ConditionMode.And => "AND",
                ConditionMode.Or => "OR",
                _ => throw new InvalidOperationException(
                    $"Unsupported condition operator: {conditionBuilder._conditionMode}")
            };
            node.FormatedExpression = string.Join($" {mode} ",
                node.Children.Select(c => "(#c)"));
            return node;
        }

        private ExpressionNode CompareBuildCondition(ConditionMode conditionMode, ExpressionNode node)
        {
            switch (conditionMode)
            {
                case ConditionMode.Equal:
                    node.FormatedExpression =
                        ExpressionFormatConstants.Equal;
                    break;
                case ConditionMode.NotEqual:
                    node.FormatedExpression =
                        ExpressionFormatConstants.NotEqual;
                    break;
                case ConditionMode.LessThan:
                    node.FormatedExpression =
                        ExpressionFormatConstants.LessThan;
                    break;
                case ConditionMode.LessThanOrEqual:
                    node.FormatedExpression =
                        ExpressionFormatConstants.LessThanOrEqual;
                    break;
                case ConditionMode.GreaterThan:
                    node.FormatedExpression =
                        ExpressionFormatConstants.GreaterThan;
                    break;
                case ConditionMode.GreaterThanOrEqual:
                    node.FormatedExpression =
                        ExpressionFormatConstants.GreaterThanOrEqual;
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported mode: {conditionMode}");
            }

            return node;
        }

        private ExpressionNode ContainsBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.Contains;
            return node;
        }

        private ExpressionNode BeginsWithBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.BeginsWith;
            return node;
        }

        private ExpressionNode AttributeTypeBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.AttributeType;
            return node;
        }

        private ExpressionNode AttributeNotExistsBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.AttributeNotExists;
            return node;
        }

        private ExpressionNode AttributeExistsBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.AttributeExists;
            return node;
        }

        private ExpressionNode InBuildCondition(ConditionExpressionBuilder conditionBuilder, ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.In;

            for(int i = 1; i < node.Children.Count; i++){
                node.FormatedExpression += "#c, ";
            }
            // Remove trailing comma and space, if any
            if (node.FormatedExpression.EndsWith(", "))
            {
                node.FormatedExpression = node.FormatedExpression.Substring(0, node.FormatedExpression.Length - 2);
            }
            node.FormatedExpression += ")";
            return node;
        }

        private ExpressionNode BetweenBuildCondition(ExpressionNode node)
        {
            node.FormatedExpression = ExpressionFormatConstants.Between;
            return node;
        }

        #endregion

    }

    /// <summary>
    /// The <see cref="NameBuilder"/> class is responsible for building attribute names
    /// for DynamoDB expressions. It allows the creation of conditions based on attribute names
    /// and supports various comparison, logical, and function-based operations.
    /// </summary>
    public partial class NameBuilder : OperandBuilder
    {
        private readonly IEnumerable<string> _names;

        private const string BracketPattern = @"\[(\d+)\]";

#if NET8_0_OR_GREATER

        [GeneratedRegex(BracketPattern)]
        private static partial Regex BracketPatternRegex();
#else
        private static Regex BracketPatternRegex() => _bracketPatternRegex;
        private static readonly Regex _bracketPatternRegex = new Regex(BracketPattern, RegexOptions.Compiled);
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="NameBuilder"/> class with the specified attribute name.
        /// </summary>
        /// <param name="name">
        /// The attribute name to be used in the expression. Supports nested attributes using dot notation
        /// (e.g., "Parent.Child[0].Grandchild").
        /// </param>
        internal NameBuilder(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                _names = name.Split('.');
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="NameBuilder"/> class with the specified attribute name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static NameBuilder New(string name)
        {
            return new NameBuilder(name);
        }

        #region ConditionExpressionBuilder

        /// <summary>
        /// Adds an attribute name to the condition.
        /// </summary>
        /// <param name="path">The attribute name or path.</param>
        /// <returns>A <see cref="NameBuilder"/> for further configuration.</returns>
        public NameBuilder WithName(string path)
        {
            return new NameBuilder(path);
        }

        /// <summary>
        /// Creates an equal condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the not-equal condition.</returns>
        public ConditionExpressionBuilder Equal(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.Equal(this, rightOperand);
        }

        /// <summary>
        /// Creates a not-equal condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the not-equal condition.</returns>
        public ConditionExpressionBuilder NotEqual(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.NotEqual(this, rightOperand);
        }

        /// <summary>
        /// Creates a less-than condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the less-than condition.</returns>
        public ConditionExpressionBuilder LessThan(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.LessThan(this, rightOperand);
        }

        /// <summary>
        /// Creates a less-than-or-equal condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the less-than-or-equal condition.</returns>
        public ConditionExpressionBuilder LessThanOrEqual(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.LessThanOrEqual(this, rightOperand);
        }

        /// <summary>
        /// Creates a greater-than condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the greater-than condition.</returns>
        public ConditionExpressionBuilder GreaterThan(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.GreaterThan(this, rightOperand);
        }

        /// <summary>
        /// Creates a greater-than-or-equal condition between the current attribute and the specified value.
        /// </summary>
        /// <param name="right">The value to compare against.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the greater-than-or-equal condition.</returns>
        public ConditionExpressionBuilder GreaterThanOrEqual(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.GreaterThanOrEqual(this, rightOperand);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute's value is between two specified values.
        /// </summary>
        /// <param name="lower">The lower bound of the range.</param>
        /// <param name="upper">The upper bound of the range.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the between condition.</returns>
        public ConditionExpressionBuilder Between(DynamoDBEntry lower, DynamoDBEntry upper)
        {
            var lowerOperand = new ValueBuilder(lower);
            var upperOperand = new ValueBuilder(upper);
            return ConditionExpressionBuilder.Between(this, lowerOperand,upperOperand);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute's value is in a specified set of values.
        /// </summary>
        /// <param name="right">The first value in the set.</param>
        /// <param name="others">Additional values in the set.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the in condition.</returns>
        public ConditionExpressionBuilder In(DynamoDBEntry right, params DynamoDBEntry[] others)
        {
            var rightOperand = new ValueBuilder(right);
            var otherOperands = others?.Select(other => new ValueBuilder(other)).Cast<OperandBuilder>().ToArray();
            return ConditionExpressionBuilder.In(this, rightOperand, otherOperands);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute exists in the DynamoDB item.
        /// </summary>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the attribute exists condition.</returns>
        public ConditionExpressionBuilder AttributeExists()
        {
            return ConditionExpressionBuilder.AttributeExists(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ConditionExpressionBuilder AttributeNotExists()
        {
            return ConditionExpressionBuilder.AttributeNotExists(this);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute has a specific DynamoDB attribute type.
        /// </summary>
        /// <param name="type">The expected DynamoDB attribute type.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the attribute type condition.</returns>
        public ConditionExpressionBuilder AttributeType(DynamoDBAttributeType type)
        {
            var rightOperand = new ValueBuilder(type.Value);
            return ConditionExpressionBuilder.AttributeType(this,rightOperand);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute's value begins with a specified prefix.
        /// </summary>
        /// <param name="right">The prefix to check for.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the begins with condition.</returns>
        public ConditionExpressionBuilder BeginsWith(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.BeginsWith(this, rightOperand);
        }

        /// <summary>
        /// Creates a condition to check if the current attribute's value contains a specified substring or value.
        /// </summary>
        /// <param name="right">The substring or value to check for.</param>
        /// <returns>A <see cref="ConditionExpressionBuilder"/> representing the contains condition.</returns>
        public ConditionExpressionBuilder Contains(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return ConditionExpressionBuilder.Contains(this, rightOperand);
        }

        #endregion

        #region UpdateExpressionBuilder

        /// <summary>
        /// Creates a "Plus" operation for the current attribute, which adds the specified value to the attribute.
        /// </summary>
        /// <param name="right">The value to add to the current attribute.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Plus" operation.</returns>
        public SetValueBuilder Plus(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return SetValueBuilder.Plus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "Minus" operation for the current attribute, which subtracts the specified value from the attribute.
        /// </summary>
        /// <param name="right">The value to subtract from the current attribute.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Minus" operation.</returns>
        public SetValueBuilder Minus(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return SetValueBuilder.Minus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "ListAppend" operation for the current attribute, which appends the specified value to a list attribute.
        /// </summary>
        /// <param name="right">The value to append to the list attribute.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "ListAppend" operation.</returns>
        public SetValueBuilder ListAppend(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return SetValueBuilder.ListAppend(this, rightOperand);
        }

        /// <summary>
        /// Creates an "IfNotExists" operation for the current attribute, which sets the attribute to the specified value
        /// if it does not already exist.
        /// </summary>
        /// <param name="setValue">The value to set if the attribute does not exist.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "IfNotExists" operation.</returns>
        public SetValueBuilder IfNotExists(DynamoDBEntry setValue)
        {
            var rightOperand = new ValueBuilder(setValue);
            return SetValueBuilder.IfNotExists(this, rightOperand);
        }

        #endregion

        /// <summary>
        /// Builds the expression node for the current attribute name.
        /// </summary>
        /// <returns>An <see cref="ExpressionNode"/> representing the attribute name in the expression.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the attribute name is invalid or unset.</exception>
        internal override ExpressionNode Build()
        {
            if (_names==null || !_names.Any())
                throw new InvalidOperationException($"Unset name parameter");

            var node = new ExpressionNode
            {
                Names = new Queue<string>()
            };

            var fmtNames = new List<string>(_names.Count());

            foreach (var originalWord in _names)
            {
                if (string.IsNullOrEmpty(originalWord))
                    throw new InvalidOperationException("Invalid parameter Name");

                var word = originalWord;
                var substr = string.Empty;

                var bracketMatches = BracketPatternRegex().Matches(word);

                if (word.Count(c => c == '[') != word.Count(c => c == ']'))
                    throw new InvalidOperationException("Invalid parameter Name");

                foreach (Match match in bracketMatches)
                {
                    if (!match.Success || match.Groups[1].Length == 0)
                        throw new InvalidOperationException("Invalid parameter Name");
                }

                // Extract suffix like [0][1] if present
                if (word.EndsWith("]"))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == '[')
                        {
                            substr = word.Substring(j);
                            word = word.Substring(0, j);
                            break;
                        }
                    }
                }

                if (string.IsNullOrEmpty(word))
                    throw new InvalidOperationException("Invalid parameter Name");

                node.Names.Enqueue(word);
                fmtNames.Add($"#n{substr}");
            }

            node.FormatedExpression = string.Join(".", fmtNames);

            return node;
        }

    }

    /// <summary>
    /// ValueBuilder is used to build attribute values for expressions.
    /// </summary>
    public class ValueBuilder : OperandBuilder
    {
        private DynamoDBEntry _value;

        /// <summary>
        /// Default constructor for ValueBuilder.
        /// </summary>
        /// <param name="value"></param>
        internal ValueBuilder(DynamoDBEntry value)
        {
            _value = value;
        }

        /// <summary>
        /// Creates a new instance of ValueBuilder with the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ValueBuilder New(DynamoDBEntry value)
        {
            return new ValueBuilder(value);
        }

        /// <summary>
        /// Creates a "Plus" operation which adds the specified operand to the current value.
        /// </summary>
        /// <param name="rightOperand">The <see cref="OperandBuilder"/> representing the operand to add.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Plus" operation.</returns>
        public SetValueBuilder Plus(OperandBuilder rightOperand)
        {
            return SetValueBuilder.Plus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "Plus" operation which adds the specified value to the current value.
        /// </summary>
        /// <param name="right">The <see cref="DynamoDBEntry"/> representing the value to add.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Plus" operation.</returns>
        public SetValueBuilder Plus(DynamoDBEntry right)
        {
            var rightOperand = new ValueBuilder(right);
            return SetValueBuilder.Plus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "Minus" operation which subtracts the specified value from the current value.
        /// </summary>
        /// <param name="right">The <see cref="DynamoDBEntry"/> representing the value to subtract.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Minus" operation.</returns>
        public SetValueBuilder Minus(DynamoDBEntry right)
        {
            var rightOperand=new ValueBuilder(right);
            return SetValueBuilder.Minus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "Minus" operation which subtracts the specified operand from the current value.
        /// </summary>
        /// <param name="rightOperand">The <see cref="OperandBuilder"/> representing the operand to subtract.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "Minus" operation.</returns>
        public SetValueBuilder Minus(OperandBuilder rightOperand)
        {
            return SetValueBuilder.Minus(this, rightOperand);
        }

        /// <summary>
        /// Creates a "ListAppend" operation for the current value, which appends the specified DynamoDB entry to a list attribute.
        /// </summary>
        /// <param name="right">The <see cref="DynamoDBEntry"/> to append to the list attribute.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "ListAppend" operation.</returns>
        /// <remarks>
        /// This operation is used to append a value to an existing list attribute in DynamoDB.
        /// If the attribute does not exist, it will be created as a list with the specified value.
        /// </remarks>
        public SetValueBuilder ListAppend(DynamoDBEntry right)
        {
            var rightOperand=new ValueBuilder(right);
            return SetValueBuilder.ListAppend(this, rightOperand);
        }

        /// <summary>
        /// Creates a "ListAppend" operation for the current value, which appends the specified operand to a list attribute.
        /// </summary>
        /// <param name="rightOperand">The <see cref="OperandBuilder"/> representing the operand to append to the list attribute.</param>
        /// <returns>A <see cref="SetValueBuilder"/> representing the "ListAppend" operation.</returns>
        /// <remarks>
        /// This operation is used to append an operand to an existing list attribute in DynamoDB.
        /// If the attribute does not exist, it will be created as a list with the specified operand.
        /// </remarks>
        public SetValueBuilder ListAppend(OperandBuilder rightOperand)
        {
            return SetValueBuilder.ListAppend(this, rightOperand);
        }


        /// <summary>
        /// Builds the current value into an <see cref="ExpressionNode"/> for use in a DynamoDB expression.
        /// </summary>
        /// <returns>An <see cref="ExpressionNode"/> representing the current value in the expression.</returns>
        /// <remarks>
        /// This method converts the internal value of the `ValueBuilder` into an expression node
        /// that can be used in DynamoDB operations. The resulting node includes the value and its
        /// formatted representation for inclusion in the final expression.
        /// </remarks>
         internal override ExpressionNode Build()
        {
            var values = new Queue<DynamoDBEntry>();
            values.Enqueue(_value);
            return new ExpressionNode
            {
                Values = values,
                FormatedExpression = ExpressionFormatConstants.Value
            };
        }
    }


    /// <summary>
    /// Abstract base class for building operands used in DynamoDB expressions.
    /// Operands represent attribute names or values in an expression.
    /// </summary>
    public abstract class OperandBuilder
    {
        /// <summary>
        /// Builds the operand into an <see cref="ExpressionNode"/> for use in an expression.
        /// </summary>
        /// <returns>An <see cref="ExpressionNode"/> representing the operand.</returns>
        internal abstract ExpressionNode Build();
    }

    /// <summary>
    /// Constants used for properties of type DynamoDB AttributeType.
    /// </summary>
    public class DynamoDBAttributeType : ConstantClass
    {
        /// <summary>
        /// Constant S for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType S = new("S");

        /// <summary>
        /// Constant SS for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType SS = new("SS");

        /// <summary>
        /// Constant N for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType N = new("N");

        /// <summary>
        /// Constant NS for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType NS = new("NS");

        /// <summary>
        /// Constant B for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType B = new("B");

        /// <summary>
        /// Constant BS for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType BS = new("BS");

        /// <summary>
        /// Constant BOOL for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType BOOL = new("BOOL");

        /// <summary>
        /// Constant NULL for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType NULL = new("NULL");

        /// <summary>
        /// Constant L for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType L = new("L");

        /// <summary>
        /// Constant M for DynamoDBAttributeType
        /// </summary>
        public static readonly DynamoDBAttributeType M = new("M");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        protected DynamoDBAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamoDBAttributeType FindValue(string value)
        {
            return FindValue<DynamoDBAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamoDBAttributeType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Enumeration of condition modes used in DynamoDB expressions.
    /// Defines comparison, logical, and function-based conditions.
    /// </summary>
    internal enum ConditionMode
    {
        // Catches errors for unset ConditionBuilder structs
        Unset = 0,

        // Comparison Conditions
        Equal,
        NotEqual,
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,

        // Logical Conditions
        And,
        Or,
        Not,

        // Function-based Conditions
        Between,
        In,
        AttributeExists,
        AttributeNotExists,
        AttributeType,
        BeginsWith,
        Contains
    }

    internal enum OperationMode
    {
        Unset = 0,
        Set,
        Remove,
        Add,
        Delete
    }

    /// <summary>
    /// Abstract base class for building operands used in DynamoDB expressions.
    /// Operands represent attribute names or values in an expression.
    /// </summary>
    internal class OperationBuilder
    {
        /// <summary>
        /// Builds the operand into an <see cref="ExpressionNode"/> for use in an expression.
        /// </summary>
        /// <returns>An <see cref="ExpressionNode"/> representing the operand.</returns>
        internal ExpressionNode Build()
        {
            var pathChild = Name.Build();

            var node = new ExpressionNode
            {
                Children = new Queue<ExpressionNode>(),
                FormatedExpression = "#c"
            };

            node.Children.Enqueue(pathChild);

            if (Mode == OperationMode.Remove)
            {
                return node;
            }

            var valueChild = Value.Build();

            node.Children.Enqueue(valueChild);

            node.FormatedExpression += Mode switch
            {
                OperationMode.Set => " = #c",
                OperationMode.Add or OperationMode.Delete => " #c",
                _ => throw new InvalidOperationException(
                    $"Update expression construction failed: unsupported update operation mode: {Mode}")
            };

            return node;
        }

        internal OperandBuilder Value { get; set; }
        internal NameBuilder Name { get; set; }
        internal OperationMode Mode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        internal OperationBuilder(OperationMode mode)
        {
            Mode = mode;
        }
    }

    /// <summary>
    /// Class for building set value expressions used in DynamoDB.
    /// </summary>
    public class SetValueBuilder: OperandBuilder
    {
        private OperandBuilder _leftOperand;
        private OperandBuilder _rightOperand;
        private SetValueMode _mode;

        private SetValueBuilder()
        {
            _mode = SetValueMode.Unset;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SetValueBuilder New()
        {
            return new SetValueBuilder();
        }

        /// <summary>
        /// Adds an attribute name to the condition.
        /// </summary>
        /// <param name="path">The attribute name or path.</param>
        /// <returns>A <see cref="NameBuilder"/> for further configuration.</returns>
        public NameBuilder WithName(string path)
        {
            return new NameBuilder(path);
        }

        /// <summary>
        /// Creates a new ValueBuilder with the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ValueBuilder WithValue(DynamoDBEntry value)
        {
            return new ValueBuilder(value);
        }

        internal static SetValueBuilder Plus(OperandBuilder left, OperandBuilder right)
        {
            return new SetValueBuilder()
            {
                _leftOperand = left,
                _rightOperand = right,
                _mode = SetValueMode.Plus
            };
        }
        internal static SetValueBuilder Minus(OperandBuilder left, OperandBuilder right)
        {
            return new SetValueBuilder()
            {
                _leftOperand = left,
                _rightOperand = right,
                _mode = SetValueMode.Minus
            };
        }

        internal static SetValueBuilder ListAppend(OperandBuilder left, OperandBuilder right)
        {
            return new SetValueBuilder()
            {
                _leftOperand = left,
                _rightOperand = right,
                _mode = SetValueMode.ListAppend
            };
        }

        internal static SetValueBuilder IfNotExists(OperandBuilder nameBuilder, OperandBuilder setValue)
        {
            return new SetValueBuilder()
            {
                _leftOperand = nameBuilder,
                _rightOperand = setValue,
                _mode = SetValueMode.IfNotExists
            };
        }

        internal override ExpressionNode Build()
        {
            if (_mode == SetValueMode.Unset)
            {
                throw new ArgumentException("Cannot build operand: SetValueBuilder is in UnsetValue mode.");
            }

            var left  = _leftOperand.Build();

            var right = _rightOperand.Build();

            var node = new ExpressionNode() 
            {
                Children = new Queue<ExpressionNode>()
            };
            node.Children.Enqueue(left);
            node.Children.Enqueue(right);

            node.FormatedExpression = _mode switch
            {
                SetValueMode.Plus => ExpressionFormatConstants.Plus,
                SetValueMode.Minus => ExpressionFormatConstants.Minus,
                SetValueMode.ListAppend=> ExpressionFormatConstants.ListAppend,
                SetValueMode.IfNotExists => ExpressionFormatConstants.IfNotExists,
                _ => throw new InvalidOperationException($"Unsupported SetValueMode: '{_mode}'.")
            };

            return node;
        }
    }

    internal enum SetValueMode
    {
        Unset = 0,
        Plus = 1,
        Minus = 2,
        ListAppend = 3,
        IfNotExists = 4,
    }
    /// <summary>
    /// Represents a node in an expression tree.    
    /// Used to construct the final expression string and manage attribute names and values.
    /// </summary>
    internal class ExpressionNode
    {
        /// <summary>
        /// Stack of attribute names used in the expression.
        /// </summary>
        public Queue<string> Names { get; set; } = new();

        /// <summary>
        /// Stack of attribute values used in the expression.
        /// </summary>
        public Queue<DynamoDBEntry> Values { get; set; } = new();

        /// <summary>
        /// The formatted expression string for this node.
        /// </summary>
        public string FormatedExpression { get; set; }

        /// <summary>
        /// Stack of child nodes representing sub-expressions.
        /// </summary>
        public Queue<ExpressionNode> Children { get; set; } = new();

        /// <summary>
        /// Builds the final expression string for this node, including attribute aliases.
        /// </summary>
        /// <param name="aliasList">A list of attribute aliases for names and values.</param>
        /// <param name="expressionType"></param>
        /// <returns>The constructed expression string.</returns>
        internal string BuildExpressionString(KeyAttributeAliasList aliasList, string expressionType)
        {
            var result = new StringBuilder();
            int i = 0;

            while (i < FormatedExpression.Length)
            {
                if (FormatedExpression[i] == '#' && i + 1 < FormatedExpression.Length)
                {
                    var next = FormatedExpression[i + 1];
                    switch (next)
                    {
                        case 'n':
                            {
                                if (Names.Count == 0)
                                    throw new InvalidOperationException("Missing name for #n");

                                string name = Names.Dequeue();
                                string alias = $"#{expressionType}{aliasList.NamesList.Count}";
                                aliasList.NamesList.Add(name);
                                result.Append(alias);
                                break;
                            }
                        case 'v':
                            {
                                if (Values.Count == 0)
                                    throw new InvalidOperationException("Missing value for #v");

                                var val = Values.Dequeue();
                                string alias = $":{expressionType}{aliasList.ValuesList.Count}";
                                aliasList.ValuesList.Add(val);
                                result.Append(alias);
                                break;
                            }
                        case 'c':
                            {
                                if (Children.Count == 0)
                                    throw new InvalidOperationException("Missing child for #c");

                                var child = Children.Dequeue();
                                string subExpr = child.BuildExpressionString(aliasList, expressionType);
                                result.Append(subExpr);
                                break;
                            }
                        default:
                            result.Append(FormatedExpression[i]); // not a known placeholder
                            break;
                    }
                    i += 2; // skip the placeholder
                }
                else
                {
                    result.Append(FormatedExpression[i]);
                    i++;
                }
            }

            return result.ToString();
        }
    }

    /// <summary>
    /// Represents a list of attribute aliases for names and values used in DynamoDB expressions.
    /// </summary>
    internal class KeyAttributeAliasList
    {
        /// <summary>
        /// List of attribute names aliases used in the expression.
        /// </summary>
        public List<string> NamesList { get; set; } = new();

        /// <summary>
        /// List of attribute values aliases used in the expression.
        /// </summary>
        public List<DynamoDBEntry> ValuesList { get; set; } = new();
    }


    /// <summary>
    /// Contains constants for formatted DynamoDB expression templates.
    /// </summary>
    internal static class ExpressionFormatConstants
    {
        public const string Equal = "#c = #c";
        public const string NotEqual = "#c <> #c";
        public const string LessThan = "#c < #c";
        public const string LessThanOrEqual = "#c <= #c";
        public const string GreaterThan = "#c > #c";
        public const string GreaterThanOrEqual = "#c >= #c";
        public const string AttributeType = "attribute_type (#c, #c)";
        public const string AttributeNotExists = "attribute_not_exists (#c)";
        public const string AttributeExists = "attribute_exists (#c)";
        public const string In = "#c IN (";
        public const string Between = "#c BETWEEN #c AND #c";
        public const string BeginsWith = "begins_with (#c, #c)";
        public const string Contains = "contains (#c, #c)";
        public const string Not = "NOT (#c)";
        public const string Value = "#v";
        public const string Plus = "#c + #c";
        public const string Minus = "#c - #c";
        public const string ListAppend = "list_append(#c, #c)";
        public const string IfNotExists = "if_not_exists(#c, #c)";
    }
}