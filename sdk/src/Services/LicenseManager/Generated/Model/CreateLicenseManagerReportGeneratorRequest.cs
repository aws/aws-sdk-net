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
    /// Container for the parameters to the CreateLicenseManagerReportGenerator operation.
    /// Creates a report generator.
    /// </summary>
    public partial class CreateLicenseManagerReportGeneratorRequest : AmazonLicenseManagerRequest
    {
        private string _clientToken;
        private string _description;
        private ReportContext _reportContext;
        private ReportFrequency _reportFrequency;
        private string _reportGeneratorName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        /// Gets and sets the property ReportContext. 
        /// <para>
        /// Defines the type of license configuration the report generator tracks.
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
        /// Frequency by which reports are generated. Reports can be generated daily, monthly,
        /// or weekly.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the report generator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of reports to generate. The following report types an be generated:
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