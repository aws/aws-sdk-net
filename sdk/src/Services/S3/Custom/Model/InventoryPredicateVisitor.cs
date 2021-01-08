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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model.Internal
{
    /// <summary>
    /// Internal implementation of Inventory Predicate visitor interface.
    /// </summary>
    internal class InventoryPredicateVisitor : IInventoryPredicateVisitor
    {
        private readonly XmlWriter xmlWriter;

        public InventoryPredicateVisitor(XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;
        }

        public void Visit(InventoryPrefixPredicate inventoryPrefixPredicate)
        {
            if (inventoryPrefixPredicate != null)
            {
                xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(inventoryPrefixPredicate.Prefix));
            }
        }
    }
}
