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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Amazon SageMaker Canvas application setting where you configure OAuth for connecting
    /// to an external data source, such as Snowflake.
    /// </summary>
    public partial class IdentityProviderOAuthSetting
    {
        private DataSourceName _dataSourceName;
        private string _secretArn;
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The name of the data source that you're connecting to. Canvas currently supports OAuth
        /// for Snowflake and Salesforce Data Cloud.
        /// </para>
        /// </summary>
        public DataSourceName DataSourceName
        {
            get { return this._dataSourceName; }
            set { this._dataSourceName = value; }
        }

        // Check to see if DataSourceName property is set
        internal bool IsSetDataSourceName()
        {
            return this._dataSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials
        /// from your identity provider, such as the client ID and secret, authorization URL,
        /// and token URL. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether OAuth for a data source is enabled or disabled in the Canvas application.
        /// </para>
        /// </summary>
        public FeatureStatus Status
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