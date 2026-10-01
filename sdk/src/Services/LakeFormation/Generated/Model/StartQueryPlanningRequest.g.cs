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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the StartQueryPlanning operation. Submits a request
    /// to process a query statement. <para> This operation generates work units that can
    /// be retrieved with the <c>GetWorkUnits</c> operation as soon as the query state is
    /// WORKUNITS_AVAILABLE or FINISHED. </para>
    /// </summary>
    public partial class StartQueryPlanningRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property QueryPlanningContext. 
        /// <para>
        /// A structure containing information about the query plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryPlanningContext QueryPlanningContext { get; set; }

        /// <summary>
        /// Checks to see if the QueryPlanningContext property is set.
        /// </summary>
        internal bool IsSetQueryPlanningContext() => this.QueryPlanningContext != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// A PartiQL query statement used as an input to the planner service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;
    }
}
