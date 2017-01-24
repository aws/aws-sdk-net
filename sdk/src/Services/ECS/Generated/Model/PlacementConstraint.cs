/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object representing a constraint on task placement. For more information, see <a
    /// href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html">Task
    /// Placement Constraints</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
    /// </summary>
    public partial class PlacementConstraint
    {
        private string _expression;
        private PlacementConstraintType _type;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A cluster query language expression to apply to the constraint. Note you cannot specify
        /// an expression if the constraint type is <code>distinctInstance</code>. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of constraint. Use <code>distinctInstance</code> to ensure that each task
        /// in a particular group is running on a different container instance. Use <code>memberOf</code>
        /// to restrict selection to a group of valid candidates. Note that <code>distinctInstance</code>
        /// is not supported in task definitions.
        /// </para>
        /// </summary>
        public PlacementConstraintType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}