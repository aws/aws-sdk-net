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
    /// <para>DescribeTapeArchivesOutput</para>
    /// </summary>
    public partial class DescribeTapeArchivesResult
    {
        
        private List<TapeArchive> tapeArchives = new List<TapeArchive>();
        private string marker;

        /// <summary>
        /// An array of virtual tape objects in the virtual tape shelf (VTS). The description includes of the Amazon Resource Name(ARN) of the virtual
        /// tapes. The information returned includes the Amazon Resource Names (ARNs) of the tapes, size of the tapes, status of the tapes, progress of
        /// the description and tape barcode.
        ///  
        /// </summary>
        public List<TapeArchive> TapeArchives
        {
            get { return this.tapeArchives; }
            set { this.tapeArchives = value; }
        }
        /// <summary>
        /// Adds elements to the TapeArchives collection
        /// </summary>
        /// <param name="tapeArchives">The values to add to the TapeArchives collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeArchivesResult WithTapeArchives(params TapeArchive[] tapeArchives)
        {
            foreach (TapeArchive element in tapeArchives)
            {
                this.tapeArchives.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TapeArchives collection
        /// </summary>
        /// <param name="tapeArchives">The values to add to the TapeArchives collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeArchivesResult WithTapeArchives(IEnumerable<TapeArchive> tapeArchives)
        {
            foreach (TapeArchive element in tapeArchives)
            {
                this.tapeArchives.Add(element);
            }

            return this;
        }

        // Check to see if TapeArchives property is set
        internal bool IsSetTapeArchives()
        {
            return this.tapeArchives.Count > 0;
        }

        /// <summary>
        /// An opaque string that indicates the position at which the virtual tapes that were fetched for description ended. Use this marker in your
        /// next request to fetch the next set of virtual tapes in the virtual tape shelf (VTS). If there are no more virtual tapes to describe, this
        /// field does not appear in the response.
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
        public DescribeTapeArchivesResult WithMarker(string marker)
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
