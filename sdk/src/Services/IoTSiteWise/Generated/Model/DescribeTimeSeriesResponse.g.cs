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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeTimeSeries operation.
    /// </summary>
    public partial class DescribeTimeSeriesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias that identifies the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the time series.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>STRUCT</c>, you must also specify <c>dataTypeSpec</c> to identify
        /// the type of the structure for this time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this time series. This parameter is required for
        /// time series that have the <c>STRUCT</c> data type.
        /// </para>
        ///  
        /// <para>
        /// The options for this parameter depend on the type of the composite model in which
        /// you created the asset property that is associated with your time series. Use <c>AWS/ALARM_STATE</c>
        /// for alarm state in alarm composite models.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataTypeSpec { get; set; }

        /// <summary>
        /// Checks to see if the DataTypeSpec property is set.
        /// </summary>
        internal bool IsSetDataTypeSpec() => this.DataTypeSpec != null;

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Checks to see if the PropertyId property is set.
        /// </summary>
        internal bool IsSetPropertyId() => this.PropertyId != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the time series, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:time-series/${TimeSeriesId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string TimeSeriesArn { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesArn property is set.
        /// </summary>
        internal bool IsSetTimeSeriesArn() => this.TimeSeriesArn != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesCreationDate. 
        /// <para>
        /// The date that the time series was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TimeSeriesCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesCreationDate property is set.
        /// </summary>
        internal bool IsSetTimeSeriesCreationDate() => this.TimeSeriesCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesLastUpdateDate. 
        /// <para>
        /// The date that the time series was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TimeSeriesLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetTimeSeriesLastUpdateDate() => this.TimeSeriesLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
