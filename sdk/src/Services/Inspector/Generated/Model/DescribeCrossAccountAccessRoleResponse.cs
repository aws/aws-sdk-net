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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the DescribeCrossAccountAccessRole operation.
    /// </summary>
    public partial class DescribeCrossAccountAccessRoleResponse : AmazonWebServiceResponse
    {
        private DateTime? _registeredAt;
        private string _roleArn;
        private bool? _valid;

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The date when the cross-account access role was registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? RegisteredAt
        {
            get { return this._registeredAt; }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN that specifies the IAM role that Amazon Inspector uses to access your AWS
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Valid. 
        /// <para>
        /// A Boolean value that specifies whether the IAM role has the necessary policies attached
        /// to enable Amazon Inspector to access your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Valid
        {
            get { return this._valid; }
            set { this._valid = value; }
        }

        // Check to see if Valid property is set
        internal bool IsSetValid()
        {
            return this._valid.HasValue; 
        }

    }
}