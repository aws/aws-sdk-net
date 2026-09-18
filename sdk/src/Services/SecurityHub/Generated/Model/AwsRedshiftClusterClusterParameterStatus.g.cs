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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The status of a parameter in a cluster parameter group for an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterClusterParameterStatus
    {
        /// <summary>
        /// Gets and sets the property ParameterApplyErrorDescription. 
        /// <para>
        /// The error that prevented the parameter from being applied to the database.
        /// </para>
        /// </summary>
        public string ParameterApplyErrorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ParameterApplyErrorDescription property is set.
        /// </summary>
        internal bool IsSetParameterApplyErrorDescription() => this.ParameterApplyErrorDescription != null;

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of the parameter. Indicates whether the parameter is in sync with the database,
        /// waiting for a cluster reboot, or encountered an error when it was applied.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>in-sync</c> | <c>pending-reboot</c> | <c>applying</c> | <c>invalid-parameter</c>
        /// | <c>apply-deferred</c> | <c>apply-error</c> | <c>unknown-error</c> 
        /// </para>
        /// </summary>
        public string ParameterApplyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterApplyStatus property is set.
        /// </summary>
        internal bool IsSetParameterApplyStatus() => this.ParameterApplyStatus != null;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;
    }
}
