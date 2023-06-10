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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataSource operation.
    /// Updates a data source.
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private DataSourceCredentials _credentials;
        private string _dataSourceId;
        private DataSourceParameters _dataSourceParameters;
        private string _name;
        private SslProperties _sslProperties;
        private VpcConnectionProperties _vpcConnectionProperties;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials that Amazon QuickSight that uses to connect to your underlying source.
        /// Currently, only credentials based on user name and password are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DataSourceCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source. This ID is unique per Amazon Web Services Region for each
        /// Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceParameters. 
        /// <para>
        /// The parameters that Amazon QuickSight uses to connect to your underlying source.
        /// </para>
        /// </summary>
        public DataSourceParameters DataSourceParameters
        {
            get { return this._dataSourceParameters; }
            set { this._dataSourceParameters = value; }
        }

        // Check to see if DataSourceParameters property is set
        internal bool IsSetDataSourceParameters()
        {
            return this._dataSourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property SslProperties. 
        /// <para>
        /// Secure Socket Layer (SSL) properties that apply when Amazon QuickSight connects to
        /// your underlying source.
        /// </para>
        /// </summary>
        public SslProperties SslProperties
        {
            get { return this._sslProperties; }
            set { this._sslProperties = value; }
        }

        // Check to see if SslProperties property is set
        internal bool IsSetSslProperties()
        {
            return this._sslProperties != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// Use this parameter only when you want Amazon QuickSight to use a VPC connection when
        /// connecting to your underlying source.
        /// </para>
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties
        {
            get { return this._vpcConnectionProperties; }
            set { this._vpcConnectionProperties = value; }
        }

        // Check to see if VpcConnectionProperties property is set
        internal bool IsSetVpcConnectionProperties()
        {
            return this._vpcConnectionProperties != null;
        }

    }
}