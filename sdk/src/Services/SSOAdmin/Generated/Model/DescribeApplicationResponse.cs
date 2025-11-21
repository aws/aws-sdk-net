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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the DescribeApplication operation.
    /// </summary>
    public partial class DescribeApplicationResponse : AmazonWebServiceResponse
    {
        private string _applicationAccount;
        private string _applicationArn;
        private string _applicationProviderArn;
        private DateTime? _createdDate;
        private string _description;
        private string _instanceArn;
        private string _name;
        private PortalOptions _portalOptions;
        private ApplicationStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationAccount. 
        /// <para>
        /// The account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ApplicationAccount
        {
            get { return this._applicationAccount; }
            set { this._applicationAccount = value; }
        }

        // Check to see if ApplicationAccount property is set
        internal bool IsSetApplicationAccount()
        {
            return this._applicationAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationProviderArn. 
        /// <para>
        /// The ARN of the application provider under which the operation will run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string ApplicationProviderArn
        {
            get { return this._applicationProviderArn; }
            set { this._applicationProviderArn = value; }
        }

        // Check to see if ApplicationProviderArn property is set
        internal bool IsSetApplicationProviderArn()
        {
            return this._applicationProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the application was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the .
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center application under which the operation will run.
        /// For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PortalOptions. 
        /// <para>
        /// A structure that describes the options for the portal associated with an application.
        /// </para>
        /// </summary>
        public PortalOptions PortalOptions
        {
            get { return this._portalOptions; }
            set { this._portalOptions = value; }
        }

        // Check to see if PortalOptions property is set
        internal bool IsSetPortalOptions()
        {
            return this._portalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether the application is enabled or disabled.
        /// </para>
        /// </summary>
        public ApplicationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}