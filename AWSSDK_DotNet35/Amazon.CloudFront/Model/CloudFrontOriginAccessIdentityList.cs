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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The CloudFrontOriginAccessIdentityList type. </para>
    /// </summary>
    public class CloudFrontOriginAccessIdentityList
    {
        
        private string marker;
        private string nextMarker;
        private int? maxItems;
        private bool? isTruncated;
        private int? quantity;
        private List<CloudFrontOriginAccessIdentitySummary> items = new List<CloudFrontOriginAccessIdentitySummary>();


        /// <summary>
        /// The value you provided for the Marker request parameter.
        ///  
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

        /// <summary>
        /// If IsTruncated is true, this element is present and contains the value you can use for the Marker request parameter to continue listing your
        /// origin access identities where they left off.
        ///  
        /// </summary>
        public string NextMarker
        {
            get { return this.nextMarker; }
            set { this.nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this.nextMarker != null;
        }

        /// <summary>
        /// The value you provided for the MaxItems request parameter.
        ///  
        /// </summary>
        public int MaxItems
        {
            get { return this.maxItems ?? default(int); }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;
        }

        /// <summary>
        /// A flag that indicates whether more origin access identities remain to be listed. If your results were truncated, you can make a follow-up
        /// pagination request using the Marker request parameter to retrieve more items in the list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// The number of CloudFront origin access identities that were created by the current AWS account.
        ///  
        /// </summary>
        public int Quantity
        {
            get { return this.quantity ?? default(int); }
            set { this.quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this.quantity.HasValue;
        }

        /// <summary>
        /// A complex type that contains one CloudFrontOriginAccessIdentitySummary element for each origin access identity that was created by the
        /// current AWS account.
        ///  
        /// </summary>
        public List<CloudFrontOriginAccessIdentitySummary> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;
        }
    }
}
