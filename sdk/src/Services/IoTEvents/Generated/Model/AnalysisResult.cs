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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains the result of the analysis.
    /// </summary>
    public partial class AnalysisResult
    {
        private AnalysisResultLevel _level;
        private List<AnalysisResultLocation> _locations = AWSConfigs.InitializeCollections ? new List<AnalysisResultLocation>() : null;
        private string _message;
        private string _type;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The severity level of the analysis result. Based on the severity level, analysis results
        /// fall into three general categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INFO</c> - An information result tells you about a significant field in your detector
        /// model. This type of result usually doesn't require immediate action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARNING</c> - A warning result draws special attention to fields that might cause
        /// issues for your detector model. We recommend that you review warnings and take necessary
        /// actions before you use your detector model in production environments. Otherwise,
        /// the detector model might not work as expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - An error result notifies you about a problem found in your detector
        /// model. You must fix all errors before you can publish your detector model.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalysisResultLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// Contains one or more locations that you can use to locate the fields in your detector
        /// model that the analysis result references.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisResultLocation> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Contains additional information about the analysis result.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the analysis result. Analyses fall into the following types based on the
        /// validators used to generate the analysis result:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>supported-actions</c> - You must specify AWS IoT Events supported actions that
        /// work with other AWS services in a supported AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-limits</c> - Resources or API operations can't exceed service quotas (also
        /// known as limits). Update your detector model or request a quota increase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>structure</c> - The detector model must follow a structure that AWS IoT Events
        /// supports. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expression-syntax</c> - Your expression must follow the required syntax.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>data-type</c> - Data types referenced in the detector model must be compatible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>referenced-data</c> - You must define the data referenced in your detector model
        /// before you can use the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>referenced-resource</c> - Resources that the detector model uses must be available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-analyze-api.html">Running
        /// detector model analyses</a> in the <i>AWS IoT Events Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}