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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Information about item collections, if any, that were affected by the operation. <i>ItemCollectionMetrics</i> is only returned if it
    /// was asked for in the request. If the table does not have any secondary indexes, this information is not returned in the response.</para>
    /// </summary>
    public class ItemCollectionMetrics
    {
        
        private Dictionary<string,AttributeValue> itemCollectionKey = new Dictionary<string,AttributeValue>();
        private List<double> sizeEstimateRangeGB = new List<double>();

        /// <summary>
        /// The hash key value of the item collection. This is the same as the hash key of the item.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> ItemCollectionKey
        {
            get { return this.itemCollectionKey; }
            set { this.itemCollectionKey = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ItemCollectionKey dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ItemCollectionKey dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ItemCollectionMetrics WithItemCollectionKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.ItemCollectionKey[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ItemCollectionKey property is set
        internal bool IsSetItemCollectionKey()
        {
            return this.itemCollectionKey != null;
        }

        /// <summary>
        /// An estimate of item collection size, measured in gigabytes. This is a two-element array containing a lower bound and an upper bound for the
        /// estimate. The estimate includes the size of all the items in the table, plus the size of all attributes projected into all of the secondary
        /// indexes on that table. Use this estimate to measure whether a secondary index is approaching its size limit. The estimate is subject to
        /// change over time; therefore, do not rely on the precision or accuracy of the estimate.
        ///  
        /// </summary>
        public List<double> SizeEstimateRangeGB
        {
            get { return this.sizeEstimateRangeGB; }
            set { this.sizeEstimateRangeGB = value; }
        }
        /// <summary>
        /// Adds elements to the SizeEstimateRangeGB collection
        /// </summary>
        /// <param name="sizeEstimateRangeGB">The values to add to the SizeEstimateRangeGB collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ItemCollectionMetrics WithSizeEstimateRangeGB(params double[] sizeEstimateRangeGB)
        {
            foreach (double element in sizeEstimateRangeGB)
            {
                this.sizeEstimateRangeGB.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SizeEstimateRangeGB collection
        /// </summary>
        /// <param name="sizeEstimateRangeGB">The values to add to the SizeEstimateRangeGB collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ItemCollectionMetrics WithSizeEstimateRangeGB(IEnumerable<double> sizeEstimateRangeGB)
        {
            foreach (double element in sizeEstimateRangeGB)
            {
                this.sizeEstimateRangeGB.Add(element);
            }

            return this;
        }

        // Check to see if SizeEstimateRangeGB property is set
        internal bool IsSetSizeEstimateRangeGB()
        {
            return this.sizeEstimateRangeGB.Count > 0;
        }
    }
}
