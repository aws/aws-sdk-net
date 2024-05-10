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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// This is a structure that contains the status of Amazon Web Services service access,
    /// and whether you have a valid service-linked role to enable multi-account search for
    /// your organization.
    /// </summary>
    public partial class OrgConfiguration
    {
        private AWSServiceAccessStatus _awsServiceAccessStatus;
        private string _serviceLinkedRole;

        /// <summary>
        /// Gets and sets the property AWSServiceAccessStatus. 
        /// <para>
        /// This value displays whether your Amazon Web Services service access is <c>ENABLED</c>
        /// or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AWSServiceAccessStatus AWSServiceAccessStatus
        {
            get { return this._awsServiceAccessStatus; }
            set { this._awsServiceAccessStatus = value; }
        }

        // Check to see if AWSServiceAccessStatus property is set
        internal bool IsSetAWSServiceAccessStatus()
        {
            return this._awsServiceAccessStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkedRole. 
        /// <para>
        /// This value shows whether or not you have a valid a service-linked role required to
        /// start the multi-account search feature.
        /// </para>
        /// </summary>
        public string ServiceLinkedRole
        {
            get { return this._serviceLinkedRole; }
            set { this._serviceLinkedRole = value; }
        }

        // Check to see if ServiceLinkedRole property is set
        internal bool IsSetServiceLinkedRole()
        {
            return this._serviceLinkedRole != null;
        }

    }
}