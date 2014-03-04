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
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTapeArchives operation.
    /// <para>Returns a description of specified virtual tapes in the virtual tape shelf (VTS). </para> <para>If a specific <c>TapeARN</c> is not
    /// specified, AWS Storage Gateway returns a description of all virtual tapes found in the VTS associated with your account.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeTapeArchives"/>
    public class DescribeTapeArchivesRequest : AmazonWebServiceRequest
    {
        private List<string> tapeARNs = new List<string>();
        private string marker;
        private int? limit;

        /// <summary>
        /// Specifies one or more unique Amazon Resource Names (ARNs) that represent the virtual tapes you want to describe.
        ///  
        /// </summary>
        public List<string> TapeARNs
        {
            get { return this.tapeARNs; }
            set { this.tapeARNs = value; }
        }
        /// <summary>
        /// Adds elements to the TapeARNs collection
        /// </summary>
        /// <param name="tapeARNs">The values to add to the TapeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeArchivesRequest WithTapeARNs(params string[] tapeARNs)
        {
            foreach (string element in tapeARNs)
            {
                this.tapeARNs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TapeARNs collection
        /// </summary>
        /// <param name="tapeARNs">The values to add to the TapeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeArchivesRequest WithTapeARNs(IEnumerable<string> tapeARNs)
        {
            foreach (string element in tapeARNs)
            {
                this.tapeARNs.Add(element);
            }

            return this;
        }

        // Check to see if TapeARNs property is set
        internal bool IsSetTapeARNs()
        {
            return this.tapeARNs.Count > 0;
        }

        /// <summary>
        /// An opaque string that indicates the position at which to begin describing virtual tapes.
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
        public DescribeTapeArchivesRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Specifies that the number of virtual tapes descried be limited to the specified number.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeArchivesRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }
    }
}
    
