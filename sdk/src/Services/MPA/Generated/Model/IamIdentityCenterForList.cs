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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// IAM Identity Center credentials. For more information see, <a href="http://aws.amazon.com/identity-center/">IAM
    /// Identity Center</a> .
    /// </summary>
    public partial class IamIdentityCenterForList
    {
        private string _approvalPortalUrl;
        private string _instanceArn;
        private string _region;

        /// <summary>
        /// Gets and sets the property ApprovalPortalUrl. 
        /// <para>
        /// URL for the approval portal associated with the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ApprovalPortalUrl
        {
            get { return this._approvalPortalUrl; }
            set { this._approvalPortalUrl = value; }
        }

        // Check to see if ApprovalPortalUrl property is set
        internal bool IsSetApprovalPortalUrl()
        {
            return this._approvalPortalUrl != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Amazon Web Services Region where the IAM Identity Center instance is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}