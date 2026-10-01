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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// This is the response object from the CreateWebLoginToken operation.
    /// </summary>
    public partial class CreateWebLoginTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AirflowIdentity. 
        /// <para>
        /// The user name of the Apache Airflow identity creating the web login token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AirflowIdentity { get; set; }

        /// <summary>
        /// Checks to see if the AirflowIdentity property is set.
        /// </summary>
        internal bool IsSetAirflowIdentity() => this.AirflowIdentity != null;

        /// <summary>
        /// Gets and sets the property IamIdentity. 
        /// <para>
        /// The name of the IAM identity creating the web login token. This might be an IAM user,
        /// or an assumed or federated identity. For example, <c>assumed-role/Admin/your-name</c>.
        /// </para>
        /// </summary>
        public string IamIdentity { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentity property is set.
        /// </summary>
        internal bool IsSetIamIdentity() => this.IamIdentity != null;

        /// <summary>
        /// Gets and sets the property WebServerHostname. 
        /// <para>
        /// The Airflow web server hostname for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WebServerHostname { get; set; }

        /// <summary>
        /// Checks to see if the WebServerHostname property is set.
        /// </summary>
        internal bool IsSetWebServerHostname() => this.WebServerHostname != null;

        /// <summary>
        /// Gets and sets the property WebToken. 
        /// <para>
        /// An Airflow web server login token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string WebToken { get; set; }

        /// <summary>
        /// Checks to see if the WebToken property is set.
        /// </summary>
        internal bool IsSetWebToken() => this.WebToken != null;
    }
}
