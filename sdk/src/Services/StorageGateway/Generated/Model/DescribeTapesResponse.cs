/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// DescribeTapesOutput
    /// </summary>
    public partial class DescribeTapesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<Tape> _tapes = new List<Tape>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string which can be used as part of a subsequent DescribeTapes call to retrieve
        /// the next page of results. 
        /// </para>
        ///  
        /// <para>
        /// If a response does not contain a marker, then there are no more results to be retrieved.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Tapes. 
        /// <para>
        /// An array of virtual tape descriptions.
        /// </para>
        /// </summary>
        public List<Tape> Tapes
        {
            get { return this._tapes; }
            set { this._tapes = value; }
        }

        // Check to see if Tapes property is set
        internal bool IsSetTapes()
        {
            return this._tapes != null && this._tapes.Count > 0; 
        }

    }
}