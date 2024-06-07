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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The mapping attributes that determine the evidence source for a given control, along
    /// with related parameters and metadata. This doesn't contain <c>mappingID</c>.
    /// </summary>
    public partial class CreateControlMappingSource
    {
        private string _sourceDescription;
        private SourceFrequency _sourceFrequency;
        private SourceKeyword _sourceKeyword;
        private string _sourceName;
        private SourceSetUpOption _sourceSetUpOption;
        private SourceType _sourceType;
        private string _troubleshootingText;

        /// <summary>
        /// Gets and sets the property SourceDescription. 
        /// <para>
        ///  The description of the data source that determines where Audit Manager collects evidence
        /// from for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string SourceDescription
        {
            get { return this._sourceDescription; }
            set { this._sourceDescription = value; }
        }

        // Check to see if SourceDescription property is set
        internal bool IsSetSourceDescription()
        {
            return this._sourceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFrequency. 
        /// <para>
        /// Specifies how often evidence is collected from the control mapping source. 
        /// </para>
        /// </summary>
        public SourceFrequency SourceFrequency
        {
            get { return this._sourceFrequency; }
            set { this._sourceFrequency = value; }
        }

        // Check to see if SourceFrequency property is set
        internal bool IsSetSourceFrequency()
        {
            return this._sourceFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property SourceKeyword.
        /// </summary>
        public SourceKeyword SourceKeyword
        {
            get { return this._sourceKeyword; }
            set { this._sourceKeyword = value; }
        }

        // Check to see if SourceKeyword property is set
        internal bool IsSetSourceKeyword()
        {
            return this._sourceKeyword != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        ///  The name of the control mapping data source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSetUpOption. 
        /// <para>
        /// The setup option for the data source. This option reflects if the evidence collection
        /// method is automated or manual. If you don’t provide a value for <c>sourceSetUpOption</c>,
        /// Audit Manager automatically infers and populates the correct value based on the <c>sourceType</c>
        /// that you specify.
        /// </para>
        /// </summary>
        public SourceSetUpOption SourceSetUpOption
        {
            get { return this._sourceSetUpOption; }
            set { this._sourceSetUpOption = value; }
        }

        // Check to see if SourceSetUpOption property is set
        internal bool IsSetSourceSetUpOption()
        {
            return this._sourceSetUpOption != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  Specifies which type of data source is used to collect evidence. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The source can be an individual data source type, such as <c>AWS_Cloudtrail</c>, <c>AWS_Config</c>,
        /// <c>AWS_Security_Hub</c>, <c>AWS_API_Call</c>, or <c>MANUAL</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The source can also be a managed grouping of data sources, such as a <c>Core_Control</c>
        /// or a <c>Common_Control</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TroubleshootingText. 
        /// <para>
        ///  The instructions for troubleshooting the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1000)]
        public string TroubleshootingText
        {
            get { return this._troubleshootingText; }
            set { this._troubleshootingText = value; }
        }

        // Check to see if TroubleshootingText property is set
        internal bool IsSetTroubleshootingText()
        {
            return this._troubleshootingText != null;
        }

    }
}