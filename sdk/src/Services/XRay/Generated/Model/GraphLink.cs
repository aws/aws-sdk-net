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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// The relation between two services.
    /// </summary>
    public partial class GraphLink
    {
        private List<string> _destinationTraceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _referenceType;
        private string _sourceTraceId;

        /// <summary>
        /// Gets and sets the property DestinationTraceIds. 
        /// <para>
        ///  Destination traces of a link relationship. 
        /// </para>
        /// </summary>
        public List<string> DestinationTraceIds
        {
            get { return this._destinationTraceIds; }
            set { this._destinationTraceIds = value; }
        }

        // Check to see if DestinationTraceIds property is set
        internal bool IsSetDestinationTraceIds()
        {
            return this._destinationTraceIds != null && (this._destinationTraceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReferenceType. 
        /// <para>
        ///  Relationship of a trace to the corresponding service. 
        /// </para>
        /// </summary>
        public string ReferenceType
        {
            get { return this._referenceType; }
            set { this._referenceType = value; }
        }

        // Check to see if ReferenceType property is set
        internal bool IsSetReferenceType()
        {
            return this._referenceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTraceId. 
        /// <para>
        ///  Source trace of a link relationship. 
        /// </para>
        /// </summary>
        public string SourceTraceId
        {
            get { return this._sourceTraceId; }
            set { this._sourceTraceId = value; }
        }

        // Check to see if SourceTraceId property is set
        internal bool IsSetSourceTraceId()
        {
            return this._sourceTraceId != null;
        }

    }
}