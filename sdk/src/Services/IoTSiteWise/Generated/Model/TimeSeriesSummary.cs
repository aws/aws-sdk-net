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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a summary of a time series (data stream).
    /// </summary>
    public partial class TimeSeriesSummary
    {
        private string _alias;
        private string _assetId;
        private PropertyDataType _dataType;
        private string _dataTypeSpec;
        private string _propertyId;
        private string _timeSeriesArn;
        private DateTime? _timeSeriesCreationDate;
        private string _timeSeriesId;
        private DateTime? _timeSeriesLastUpdateDate;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias that identifies the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the time series.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>STRUCT</code>, you must also specify <code>dataTypeSpec</code>
        /// to identify the type of the structure for this time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this time series. This parameter is required for
        /// time series that have the <code>STRUCT</code> data type.
        /// </para>
        ///  
        /// <para>
        /// The options for this parameter depend on the type of the composite model in which
        /// you created the asset property that is associated with your time series. Use <code>AWS/ALARM_STATE</code>
        /// for alarm state in alarm composite models.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataTypeSpec
        {
            get { return this._dataTypeSpec; }
            set { this._dataTypeSpec = value; }
        }

        // Check to see if DataTypeSpec property is set
        internal bool IsSetDataTypeSpec()
        {
            return this._dataTypeSpec != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PropertyId
        {
            get { return this._propertyId; }
            set { this._propertyId = value; }
        }

        // Check to see if PropertyId property is set
        internal bool IsSetPropertyId()
        {
            return this._propertyId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the time series, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:${Partition}:iotsitewise:${Region}:${Account}:time-series/${TimeSeriesId}</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string TimeSeriesArn
        {
            get { return this._timeSeriesArn; }
            set { this._timeSeriesArn = value; }
        }

        // Check to see if TimeSeriesArn property is set
        internal bool IsSetTimeSeriesArn()
        {
            return this._timeSeriesArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesCreationDate. 
        /// <para>
        /// The date that the time series was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime TimeSeriesCreationDate
        {
            get { return this._timeSeriesCreationDate.GetValueOrDefault(); }
            set { this._timeSeriesCreationDate = value; }
        }

        // Check to see if TimeSeriesCreationDate property is set
        internal bool IsSetTimeSeriesCreationDate()
        {
            return this._timeSeriesCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesLastUpdateDate. 
        /// <para>
        /// The date that the time series was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime TimeSeriesLastUpdateDate
        {
            get { return this._timeSeriesLastUpdateDate.GetValueOrDefault(); }
            set { this._timeSeriesLastUpdateDate = value; }
        }

        // Check to see if TimeSeriesLastUpdateDate property is set
        internal bool IsSetTimeSeriesLastUpdateDate()
        {
            return this._timeSeriesLastUpdateDate.HasValue; 
        }

    }
}