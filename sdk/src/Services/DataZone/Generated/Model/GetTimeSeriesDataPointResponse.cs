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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetTimeSeriesDataPoint operation.
    /// </summary>
    public partial class GetTimeSeriesDataPointResponse : AmazonWebServiceResponse
    {
        private string _domainId;
        private string _entityId;
        private TimeSeriesEntityType _entityType;
        private TimeSeriesDataPointFormOutput _form;
        private string _formName;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain that houses the asset data point that you want
        /// to get.
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the asset for which you want to get the data point.
        /// </para>
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the asset for which you want to get the data point.
        /// </para>
        /// </summary>
        public TimeSeriesEntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property Form. 
        /// <para>
        /// The time series form that houses the data point that you want to get.
        /// </para>
        /// </summary>
        public TimeSeriesDataPointFormOutput Form
        {
            get { return this._form; }
            set { this._form = value; }
        }

        // Check to see if Form property is set
        internal bool IsSetForm()
        {
            return this._form != null;
        }

        /// <summary>
        /// Gets and sets the property FormName. 
        /// <para>
        /// The name of the time series form that houses the data point that you want to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FormName
        {
            get { return this._formName; }
            set { this._formName = value; }
        }

        // Check to see if FormName property is set
        internal bool IsSetFormName()
        {
            return this._formName != null;
        }

    }
}