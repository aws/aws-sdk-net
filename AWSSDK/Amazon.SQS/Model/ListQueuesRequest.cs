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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Returns a list of your queues. The maximum number of queues that can be returned is 1000.
    /// </summary>
    /// <remarks>
    /// If you specify a value for the optional QueueNamePrefix parameter, only queues with a name beginning with the
    /// specified value are returned.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class ListQueuesRequest : SQSRequest
    {    
        private string queueNamePrefixField;
        private List<Attribute> attributeField;

        /// <summary>
        /// Prefix to use for filtering the list results. Only those queues whose name begins with the prefix are returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueNamePrefix")]
        public string QueueNamePrefix
        {
            get { return this.queueNamePrefixField; }
            set { this.queueNamePrefixField = value; }
        }

        /// <summary>
        /// Sets the prefix to use for filtering the list results. Only those queues whose name begins with the prefix are returned.
        /// </summary>
        /// <param name="queueNamePrefix">Prefix to use for filtering the list results.</param>
        /// <returns>this instance</returns>
        public ListQueuesRequest WithQueueNamePrefix(string queueNamePrefix)
        {
            this.queueNamePrefixField = queueNamePrefix;
            return this;
        }

        /// <summary>
        /// Checks if QueueNamePrefix property is set
        /// </summary>
        /// <returns>true if QueueNamePrefix property is set</returns>
        public bool IsSetQueueNamePrefix()
        {
            return this.queueNamePrefixField != null;
        }

        /// <summary>
        /// Name and value pair of an attribute associated with the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<Attribute> Attribute
        {
            get
            {
                if (this.attributeField == null)
                {
                    this.attributeField = new List<Attribute>();
                }
                return this.attributeField;
            }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the name and value pair of an attribute associated with the queue.
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public ListQueuesRequest WithAttribute(params Attribute[] list)
        {
            foreach (Attribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
        }

    }
}
