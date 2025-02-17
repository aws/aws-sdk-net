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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.IoTSiteWise.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This contains the SiteWise Assistant's response and the corresponding citation.
    /// </summary>
    public partial class InvocationOutput
        : IEventStreamEvent
    {
        private List<Citation> _citations = AWSConfigs.InitializeCollections ? new List<Citation>() : null;
        private string _message;

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// A list of citations, and related information for the SiteWise Assistant's response.
        /// </para>
        /// </summary>
        public List<Citation> Citations
        {
            get { return this._citations; }
            set { this._citations = value; }
        }

        // Check to see if Citations property is set
        internal bool IsSetCitations()
        {
            return this._citations != null && (this._citations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The text message of the SiteWise Assistant's response.
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

    }
}