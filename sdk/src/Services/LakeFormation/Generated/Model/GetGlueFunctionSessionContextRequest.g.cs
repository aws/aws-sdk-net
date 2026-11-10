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
    /// Container for the parameters to the GetGlueFunctionSessionContext operation. Returns
    /// a session context for one or more user-defined functions that an integrated analytics
    /// engine runs together in a job. You must have the <c>EXECUTE</c> permission on every
    /// function in the list. <para> While the session context is in use, if you don't have
    /// full <c>SELECT</c> permission on a table, the job can read the table only if every
    /// function in the session has the <c>SELECT</c> permission on it. Lake Formation enforces
    /// this check. </para> <para> To use this operation, you must have the <c>lakeformation:GetDataAccess</c>
    /// permission. </para>
    /// </summary>
    public partial class GetGlueFunctionSessionContextRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The number of seconds the session context is valid. The default is 86,400 (24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UserDefinedFunctionArns. 
        /// <para>
        /// The ARNs of one or more user-defined functions to include in the session context,
        /// each in the format <c>arn:aws:glue:<i>region</i>:<i>account-id</i>:userDefinedFunction/<i>database-name</i>/<i>function-name</i>
        /// </c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public List<string> UserDefinedFunctionArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserDefinedFunctionArns property is set.
        /// </summary>
        internal bool IsSetUserDefinedFunctionArns() => this.UserDefinedFunctionArns != null && (this.UserDefinedFunctionArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
