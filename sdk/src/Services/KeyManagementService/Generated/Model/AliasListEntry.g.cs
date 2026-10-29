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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Contains information about an alias.
    /// </summary>
    public partial class AliasListEntry
    {
        /// <summary>
        /// Gets and sets the property AliasArn. 
        /// <para>
        /// String that contains the key ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AliasArn { get; set; }

        /// <summary>
        /// Checks to see if the AliasArn property is set.
        /// </summary>
        internal bool IsSetAliasArn() => this.AliasArn != null;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// String that contains the alias. This value begins with <c>alias/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Date and time that the alias was most recently created in the account and Region.
        /// Formatted as Unix time.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Date and time that the alias was most recently associated with a KMS key in the account
        /// and Region. Formatted as Unix time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property TargetKeyId. 
        /// <para>
        /// String that contains the key identifier of the KMS key associated with the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TargetKeyId { get; set; }

        /// <summary>
        /// Checks to see if the TargetKeyId property is set.
        /// </summary>
        internal bool IsSetTargetKeyId() => this.TargetKeyId != null;
    }
}
