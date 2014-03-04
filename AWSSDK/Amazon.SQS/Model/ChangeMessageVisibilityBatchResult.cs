/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Returns a list of ChangeMessageVisibilityBatchResultEntries.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class ChangeMessageVisibilityBatchResult
    {
        private List<ChangeMessageVisibilityBatchResultEntry> changeMessageVisibilityBatchResultEntryField;
        private List<BatchResultErrorEntry> batchResultErrorEntryField;

        /// <summary>
        /// Gets and sets the ChangeMessageVisibilityBatchResultEntry property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ChangeMessageVisibilityBatchResultEntry")]
        public List<ChangeMessageVisibilityBatchResultEntry> ChangeMessageVisibilityBatchResultEntry
        {
            get
            {
                if (this.changeMessageVisibilityBatchResultEntryField == null)
                {
                    this.changeMessageVisibilityBatchResultEntryField = new List<ChangeMessageVisibilityBatchResultEntry>();
                }
                return this.changeMessageVisibilityBatchResultEntryField;
            }
            set { this.changeMessageVisibilityBatchResultEntryField = value; }
        }

        /// <summary>
        /// Checks if ChangeMessageVisibilityBatchResultEntry property is set
        /// </summary>
        /// <returns>true if ChangeMessageVisibilityBatchResultEntry property is set</returns>
        public bool IsSetChangeMessageVisibilityBatchResultEntry()
        {
            return (changeMessageVisibilityBatchResultEntryField.Count > 0);
        }

        /// <summary>
        /// Gets and sets the BatchResultErrorEntry property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BatchResultErrorEntry")]
        public List<BatchResultErrorEntry> BatchResultErrorEntry
        {
            get
            {
                if (this.batchResultErrorEntryField == null)
                {
                    this.batchResultErrorEntryField = new List<BatchResultErrorEntry>();
                }
                return this.batchResultErrorEntryField;
            }
            set { this.batchResultErrorEntryField = value; }
        }

        /// <summary>
        /// Checks if BatchResultErrorEntry property is set
        /// </summary>
        /// <returns>true if BatchResultErrorEntry property is set</returns>
        public bool IsSetBatchResultErrorEntry()
        {
            return (batchResultErrorEntryField.Count > 0);
        }
    }
}
