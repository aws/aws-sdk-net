/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The structure of a data source.
    /// </summary>
    public partial class DataSource
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _dataSourceId;
        private DataSourceParameters _dataSourceParameters;
        private DataSourceErrorInfo _errorInfo;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private SslProperties _sslProperties;
        private ResourceStatus _status;
        private DataSourceType _type;
        private VpcConnectionProperties _vpcConnectionProperties;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource name (ARN) of the data source.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time this was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source. This ID is unique per AWS Region for each AWS account.
        /// </para>
        /// </summary>
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
        /// The parameters that QuickSight uses to connect to your underlying source. This is
        /// a variant type structure. At most one of the attributes should be non-null for this
        /// structure to be valid.
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
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information from the last update or the creation of the data source.
        /// </para>
        /// </summary>
        public DataSourceErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time this was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Secure Socket Layer (SSL) properties that apply when QuickSight connects to your underlying
        /// source.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. This indicates which database engine the data source
        /// connects to.
        /// </para>
        /// </summary>
        public DataSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// The VPC connection information. You need to use this parameter only when you want
        /// QuickSight to use a VPC connection when connecting to your underlying source.
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