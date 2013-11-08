/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>DescribeTapesOutput</para>
    /// </summary>
    public partial class DescribeTapesResult : AmazonWebServiceResponse
    {
        
        private List<Tape> tapes = new List<Tape>();
        private string marker;


        /// <summary>
        /// An array of virtual tape descriptions.
        ///  
        /// </summary>
        public List<Tape> Tapes
        {
            get { return this.tapes; }
            set { this.tapes = value; }
        }

        // Check to see if Tapes property is set
        internal bool IsSetTapes()
        {
            return this.tapes.Count > 0;
        }

        /// <summary>
        /// An opaque string which can be used as part of a subsequent DescribeTapes call to retrieve the next page of results. If a response does not
        /// contain a marker, then there are no more results to be retrieved.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
