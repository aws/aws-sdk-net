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
    /// Internal implementation of Metrics Predicate visitor interface.
    /// </summary>
    internal class AnalyticsPredicateVisitor:IAnalyticsPredicateVisitor
    {
        private readonly XmlWriter xmlWriter;

        public AnalyticsPredicateVisitor(XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;
        }

        public void Visit(AnalyticsPrefixPredicate analyticsPrefixPredicate)
        {
            if(analyticsPrefixPredicate!=null)
                xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(analyticsPrefixPredicate.Prefix));
        }

        public void visit(AnalyticsTagPredicate analyticsTagPredicate)
        {
            if (analyticsTagPredicate != null)
            {
                xmlWriter.WriteStartElement("Tag", "http://s3.amazonaws.com/doc/2006-03-01/");
                if(analyticsTagPredicate.Tag.IsSetKey())
                    xmlWriter.WriteElementString("Key", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(analyticsTagPredicate.Tag.Key));
                if(analyticsTagPredicate.Tag.IsSetValue())
                    xmlWriter.WriteElementString("Value", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(analyticsTagPredicate.Tag.Value));
                xmlWriter.WriteEndElement();
            }
            
        }

        public void visit(AnalyticsAndOperator analyticsAndOperatorPredicate)
        {
            if (analyticsAndOperatorPredicate != null)
            {
                xmlWriter.WriteStartElement("And", "http://s3.amazonaws.com/doc/2006-03-01/");
                foreach (var predicate in analyticsAndOperatorPredicate.Operands)
                {
                    if(predicate!=null)
                        predicate.Accept(this);
                }
                xmlWriter.WriteEndElement();
            }
        }
    }
}
