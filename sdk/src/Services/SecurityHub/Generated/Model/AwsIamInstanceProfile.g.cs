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
    /// Information about an instance profile.
    /// </summary>
    public partial class AwsIamInstanceProfile
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the instance profile.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the instance profile was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileId. 
        /// <para>
        /// The identifier of the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileId property is set.
        /// </summary>
        internal bool IsSetInstanceProfileId() => this.InstanceProfileId != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The name of the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileName property is set.
        /// </summary>
        internal bool IsSetInstanceProfileName() => this.InstanceProfileName != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the instance profile.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// The roles associated with the instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamInstanceProfileRole> Roles { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsIamInstanceProfileRole>() : null;

        /// <summary>
        /// Checks to see if the Roles property is set.
        /// </summary>
        internal bool IsSetRoles() => this.Roles != null && (this.Roles.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
