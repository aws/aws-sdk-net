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
    /// This is the response object from the GetClusterCredentialsWithIAM operation.
    /// </summary>
    public partial class GetClusterCredentialsWithIAMResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DbPassword. 
        /// <para>
        /// A temporary password that you provide when you connect to a database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DbPassword { get; set; }

        /// <summary>
        /// Checks to see if the DbPassword property is set.
        /// </summary>
        internal bool IsSetDbPassword() => this.DbPassword != null;

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// A database user name that you provide when you connect to a database. The database
        /// user is mapped 1:1 to the source IAM identity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DbUser { get; set; }

        /// <summary>
        /// Checks to see if the DbUser property is set.
        /// </summary>
        internal bool IsSetDbUser() => this.DbUser != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The time (UTC) when the temporary password expires. After this timestamp, a log in
        /// with the temporary password fails.
        /// </para>
        /// </summary>
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property NextRefreshTime. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public DateTime? NextRefreshTime { get; set; }

        /// <summary>
        /// Checks to see if the NextRefreshTime property is set.
        /// </summary>
        internal bool IsSetNextRefreshTime() => this.NextRefreshTime.HasValue;
    }
}
