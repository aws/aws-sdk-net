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
    internal class MetricsPredicateVisitor:IMetricsPredicateVisitor
    {
        private readonly XmlWriter xmlWriter;

        public MetricsPredicateVisitor(XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;
        }

        public void Visit(MetricsPrefixPredicate metricsPrefixPredicate)
        {
            if (metricsPrefixPredicate != null)
            {
                xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(metricsPrefixPredicate.Prefix));
            }            
        }

        public void visit(MetricsTagPredicate metricsTagPredicate)
        {
            if (metricsTagPredicate != null)
            {
                xmlWriter.WriteStartElement("Tag", "http://s3.amazonaws.com/doc/2006-03-01/");
                if(metricsTagPredicate.Tag.IsSetKey())
                    xmlWriter.WriteElementString("Key", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(metricsTagPredicate.Tag.Key));
                if(metricsTagPredicate.Tag.IsSetValue())
                    xmlWriter.WriteElementString("Value", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(metricsTagPredicate.Tag.Value));
                xmlWriter.WriteEndElement();
            }
        }

        public void visit(MetricsAndOperator metricsAndOperatorPredicate)
        {
            if (metricsAndOperatorPredicate != null)
            {
                xmlWriter.WriteStartElement("And", "http://s3.amazonaws.com/doc/2006-03-01/");
                foreach (var predicate in metricsAndOperatorPredicate.Operands)
                {
                    if(predicate!=null)
                        predicate.Accept(this);
                }
                xmlWriter.WriteEndElement();
            }
        }

        public void visit(MetricsAccessPointArnPredicate metricsAccessPointArnPredicate)
        {
            if (metricsAccessPointArnPredicate != null)
            {
                xmlWriter.WriteElementString("AccessPointArn", "http://s3.amazonaws.com/doc/2006-03-01/", S3Transforms.ToXmlStringValue(metricsAccessPointArnPredicate.AccessPointArn));
            }
        }
    }
}
