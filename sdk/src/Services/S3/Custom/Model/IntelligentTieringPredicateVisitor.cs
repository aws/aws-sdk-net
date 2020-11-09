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
using Amazon.S3.Model.Internal.MarshallTransformations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Amazon.S3.Model.Internal
{
	/// <summary>
	/// Internal implementation of Intelligent-Tiering Predicate visitor interface.
	/// </summary>
	internal class IntelligentTieringPredicateVisitor : IIntelligentTieringPredicateVisitor
	{
		private readonly XmlWriter xmlWriter;

        public IntelligentTieringPredicateVisitor(XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;
        }

        public void Visit(IntelligentTieringPrefixPredicate intelligentTieringPrefixPredicate)
        {
            if (intelligentTieringPrefixPredicate != null)
            {
                xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(intelligentTieringPrefixPredicate.Prefix));
            }
        }

        public void Visit(IntelligentTieringTagPredicate intelligentTieringTagPredicate)
        {
            if (intelligentTieringTagPredicate != null)
            {
                xmlWriter.WriteStartElement("Tag", "http://s3.amazonaws.com/doc/2006-03-01/");
                if (intelligentTieringTagPredicate.Tag.IsSetKey())
                    xmlWriter.WriteElementString("Key", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(intelligentTieringTagPredicate.Tag.Key));
                if (intelligentTieringTagPredicate.Tag.IsSetValue())
                    xmlWriter.WriteElementString("Value", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(intelligentTieringTagPredicate.Tag.Value));
                xmlWriter.WriteEndElement();
            }
        }

        public void Visit(IntelligentTieringAndOperator intelligentTieringAndOperatorPredicate)
        {
            if (intelligentTieringAndOperatorPredicate != null)
            {
                xmlWriter.WriteStartElement("And", "http://s3.amazonaws.com/doc/2006-03-01/");
                foreach (var predicate in intelligentTieringAndOperatorPredicate.Operands)
                {
                    if (predicate != null)
                        predicate.Accept(this);
                }
                xmlWriter.WriteEndElement();
            }
        }
    }
}
