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
    /// A structure that describes a filter for applications.
    /// </summary>
    public partial class ListApplicationsFilter
    {
        private string _applicationAccount;
        private string _applicationProvider;

        /// <summary>
        /// Gets and sets the property ApplicationAccount. 
        /// <para>
        /// An Amazon Web Services account ID number that filters the results in the response.
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
        /// Gets and sets the property ApplicationProvider. 
        /// <para>
        /// The ARN of an application provider that can filter the results in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string ApplicationProvider
        {
            get { return this._applicationProvider; }
            set { this._applicationProvider = value; }
        }

        // Check to see if ApplicationProvider property is set
        internal bool IsSetApplicationProvider()
        {
            return this._applicationProvider != null;
        }

    }
}