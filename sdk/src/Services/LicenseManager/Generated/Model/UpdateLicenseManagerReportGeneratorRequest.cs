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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLicenseManagerReportGenerator operation.
    /// Updates a report generator.
    /// 
    ///  
    /// <para>
    /// After you make changes to a report generator, it starts generating new reports within
    /// 60 minutes of being updated.
    /// </para>
    /// </summary>
    public partial class UpdateLicenseManagerReportGeneratorRequest : AmazonLicenseManagerRequest
    {
        private string _clientToken;
        private string _description;
        private string _licenseManagerReportGeneratorArn;
        private ReportContext _reportContext;
        private ReportFrequency _reportFrequency;
        private string _reportGeneratorName;
        private List<string> _type = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the report generator.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseManagerReportGeneratorArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the report generator to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseManagerReportGeneratorArn
        {
            get { return this._licenseManagerReportGeneratorArn; }
            set { this._licenseManagerReportGeneratorArn = value; }
        }

        // Check to see if LicenseManagerReportGeneratorArn property is set
        internal bool IsSetLicenseManagerReportGeneratorArn()
        {
            return this._licenseManagerReportGeneratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReportContext. 
        /// <para>
        /// The report context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportContext ReportContext
        {
            get { return this._reportContext; }
            set { this._reportContext = value; }
        }

        // Check to see if ReportContext property is set
        internal bool IsSetReportContext()
        {
            return this._reportContext != null;
        }

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Frequency by which reports are generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportFrequency ReportFrequency
        {
            get { return this._reportFrequency; }
            set { this._reportFrequency = value; }
        }

        // Check to see if ReportFrequency property is set
        internal bool IsSetReportFrequency()
        {
            return this._reportFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ReportGeneratorName. 
        /// <para>
        /// Name of the report generator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ReportGeneratorName
        {
            get { return this._reportGeneratorName; }
            set { this._reportGeneratorName = value; }
        }

        // Check to see if ReportGeneratorName property is set
        internal bool IsSetReportGeneratorName()
        {
            return this._reportGeneratorName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of reports to generate. The following report types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// License configuration report - Reports the number and details of consumed licenses
        /// for a license configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource report - Reports the tracked licenses and resource consumption for a license
        /// configuration.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && (this._type.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}