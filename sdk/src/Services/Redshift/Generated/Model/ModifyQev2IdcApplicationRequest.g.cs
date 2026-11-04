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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyQev2IdcApplication operation. Modifies an
    /// Amazon Redshift Query Editor (QEV2) IAM Identity Center application.
    /// </summary>
    public partial class ModifyQev2IdcApplicationRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property IdcDisplayName. 
        /// <para>
        /// The display name for the Amazon Redshift Query Editor (QEV2) IAM Identity Center application.
        /// It appears in the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string IdcDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IdcDisplayName property is set.
        /// </summary>
        internal bool IsSetIdcDisplayName() => this.IdcDisplayName != null;

        /// <summary>
        /// Gets and sets the property Qev2IdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Amazon Redshift Query Editor (QEV2) application
        /// that integrates with IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string Qev2IdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the Qev2IdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetQev2IdcApplicationArn() => this.Qev2IdcApplicationArn != null;
    }
}
