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

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains the result of the analysis.
    /// </summary>
    public partial class AnalysisResult
    {
        private AnalysisResultLevel _level;
        private List<AnalysisResultLocation> _locations = new List<AnalysisResultLocation>();
        private string _message;
        private string _type;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The severity level of the analysis result. Analysis results fall into three general
        /// categories based on the severity level:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INFO</code> - An information result informs you about a significant field in
        /// your detector model. This type of result usually doesn't require immediate action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WARNING</code> - A warning result draws special attention to fields that are
        /// potentially damaging to your detector model. We recommend that you review warnings
        /// and take necessary actions before you use your detetor model in production environments.
        /// Otherwise, the detector model may not fully function as expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR</code> - An error result notifies you about a problem found in your detector
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
        /// </summary>
        public List<AnalysisResultLocation> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && this._locations.Count > 0; 
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
        ///  <code>supported-actions</code> - You must specify AWS IoT Events supported actions
        /// that work with other AWS services in a supported AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>service-limits</code> - Resources or operations can't exceed service limits.
        /// Update your detector model or request a limit adjust.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>structure</code> - The detector model must follow a structure that AWS IoT
        /// Events supports. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expression-syntax</code> - Your expression must follow the required syntax.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>data-type</code> - Data types referenced in the detector model must be compatible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>referenced-data</code> - You must define the data referenced in your detector
        /// model before you can use the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>referenced-resource</code> - Resources that the detector model uses must be
        /// available.
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