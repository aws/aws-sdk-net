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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomLogSource operation.
    /// Adds a third-party custom source in Amazon Security Lake, from the Amazon Web Services
    /// Region where you want to create a custom source. Security Lake can collect logs and
    /// events from third-party custom sources. After creating the appropriate IAM role to
    /// invoke Glue crawler, use this API to add a custom source name in Security Lake. This
    /// operation creates a partition in the Amazon S3 bucket for Security Lake as the target
    /// location for log files from the custom source in addition to an associated Glue table
    /// and an Glue crawler.
    /// </summary>
    public partial class CreateCustomLogSourceRequest : AmazonSecurityLakeRequest
    {
        private string _customSourceName;
        private OcsfEventClass _eventClass;
        private string _glueInvocationRoleArn;
        private string _logProviderAccountId;

        /// <summary>
        /// Gets and sets the property CustomSourceName. 
        /// <para>
        /// The name for a third-party custom source. This must be a Regionally unique value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomSourceName
        {
            get { return this._customSourceName; }
            set { this._customSourceName = value; }
        }

        // Check to see if CustomSourceName property is set
        internal bool IsSetCustomSourceName()
        {
            return this._customSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property EventClass. 
        /// <para>
        /// The Open Cybersecurity Schema Framework (OCSF) event class which describes the type
        /// of data that the custom source will send to Security Lake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OcsfEventClass EventClass
        {
            get { return this._eventClass; }
            set { this._eventClass = value; }
        }

        // Check to see if EventClass property is set
        internal bool IsSetEventClass()
        {
            return this._eventClass != null;
        }

        /// <summary>
        /// Gets and sets the property GlueInvocationRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role to
        /// be used by the Glue crawler. The recommended IAM policies are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The managed policy <code>AWSGlueServiceRole</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A custom policy granting access to your Amazon S3 Data Lake
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlueInvocationRoleArn
        {
            get { return this._glueInvocationRoleArn; }
            set { this._glueInvocationRoleArn = value; }
        }

        // Check to see if GlueInvocationRoleArn property is set
        internal bool IsSetGlueInvocationRoleArn()
        {
            return this._glueInvocationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogProviderAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the custom source that will write logs and events
        /// into the Amazon S3 Data Lake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string LogProviderAccountId
        {
            get { return this._logProviderAccountId; }
            set { this._logProviderAccountId = value; }
        }

        // Check to see if LogProviderAccountId property is set
        internal bool IsSetLogProviderAccountId()
        {
            return this._logProviderAccountId != null;
        }

    }
}