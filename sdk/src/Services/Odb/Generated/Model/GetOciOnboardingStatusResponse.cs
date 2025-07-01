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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the GetOciOnboardingStatus operation.
    /// </summary>
    public partial class GetOciOnboardingStatusResponse : AmazonWebServiceResponse
    {
        private string _existingTenancyActivationLink;
        private string _newTenancyActivationLink;
        private OciOnboardingStatus _status;

        /// <summary>
        /// Gets and sets the property ExistingTenancyActivationLink. 
        /// <para>
        /// The existing OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ExistingTenancyActivationLink
        {
            get { return this._existingTenancyActivationLink; }
            set { this._existingTenancyActivationLink = value; }
        }

        // Check to see if ExistingTenancyActivationLink property is set
        internal bool IsSetExistingTenancyActivationLink()
        {
            return this._existingTenancyActivationLink != null;
        }

        /// <summary>
        /// Gets and sets the property NewTenancyActivationLink. 
        /// <para>
        /// A new OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string NewTenancyActivationLink
        {
            get { return this._newTenancyActivationLink; }
            set { this._newTenancyActivationLink = value; }
        }

        // Check to see if NewTenancyActivationLink property is set
        internal bool IsSetNewTenancyActivationLink()
        {
            return this._newTenancyActivationLink != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public OciOnboardingStatus Status
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