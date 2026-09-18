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
    /// Provides information about a parameter group for a DB instance.
    /// </summary>
    public partial class AwsRdsDbParameterGroup
    {
        /// <summary>
        /// Gets and sets the property DbParameterGroupName. 
        /// <para>
        /// The name of the parameter group.
        /// </para>
        /// </summary>
        public string DbParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DbParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDbParameterGroupName() => this.DbParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates.
        /// </para>
        /// </summary>
        public string ParameterApplyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterApplyStatus property is set.
        /// </summary>
        internal bool IsSetParameterApplyStatus() => this.ParameterApplyStatus != null;
    }
}
