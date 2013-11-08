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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>DescribeTapesOutput</para>
    /// </summary>
    public partial class DescribeTapesResult
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
        /// <summary>
        /// Adds elements to the Tapes collection
        /// </summary>
        /// <param name="tapes">The values to add to the Tapes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapesResult WithTapes(params Tape[] tapes)
        {
            foreach (Tape element in tapes)
            {
                this.tapes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Tapes collection
        /// </summary>
        /// <param name="tapes">The values to add to the Tapes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapesResult WithTapes(IEnumerable<Tape> tapes)
        {
            foreach (Tape element in tapes)
            {
                this.tapes.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
