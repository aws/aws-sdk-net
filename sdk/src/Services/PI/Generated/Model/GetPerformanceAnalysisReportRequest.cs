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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the GetPerformanceAnalysisReport operation.
    /// Retrieves the report including the report ID, status, time details, and the insights
    /// with recommendations. The report status can be <c>RUNNING</c>, <c>SUCCEEDED</c>, or
    /// <c>FAILED</c>. The insights include the <c>description</c> and <c>recommendation</c>
    /// fields.
    /// </summary>
    public partial class GetPerformanceAnalysisReportRequest : AmazonPIRequest
    {
        private AcceptLanguage _acceptLanguage;
        private string _analysisReportId;
        private string _identifier;
        private ServiceType _serviceType;
        private TextFormat _textFormat;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The text language in the report. The default language is <c>EN_US</c> (English). 
        /// </para>
        /// </summary>
        public AcceptLanguage AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisReportId. 
        /// <para>
        /// A unique identifier of the created analysis report. For example, <c>report-12345678901234567</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AnalysisReportId
        {
            get { return this._analysisReportId; }
            set { this._analysisReportId = value; }
        }

        // Check to see if AnalysisReportId property is set
        internal bool IsSetAnalysisReportId()
        {
            return this._analysisReportId != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique for an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. In the console,
        /// the identifier is shown as <i>ResourceID</i>. When you call <c>DescribeDBInstances</c>,
        /// the identifier is returned as <c>DbiResourceId</c>.
        /// </para>
        ///  
        /// <para>
        /// To use a DB instance as a data source, specify its <c>DbiResourceId</c> value. For
        /// example, specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights will return metrics.
        /// Valid value is <c>RDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

        /// <summary>
        /// Gets and sets the property TextFormat. 
        /// <para>
        /// Indicates the text format in the report. The options are <c>PLAIN_TEXT</c> or <c>MARKDOWN</c>.
        /// The default value is <c>plain text</c>.
        /// </para>
        /// </summary>
        public TextFormat TextFormat
        {
            get { return this._textFormat; }
            set { this._textFormat = value; }
        }

        // Check to see if TextFormat property is set
        internal bool IsSetTextFormat()
        {
            return this._textFormat != null;
        }

    }
}