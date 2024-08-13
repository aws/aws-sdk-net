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
using System.Xml;

namespace Amazon.S3.Model.Internal
{
    /// <summary>
    /// Defines the interface that is used to visit all the different
    /// implementations of <see cref="LifecycleFilterPredicate"/>
    /// </summary>
    internal interface ILifecyclePredicateVisitor
    {
        /// <summary>
        /// Visit a <see cref="LifecyclePrefixPredicate"/>
        /// </summary>
        /// <param name="lifecyclePrefixPredicate"></param>
        void Visit(LifecyclePrefixPredicate lifecyclePrefixPredicate);

        /// <summary>
        /// Visit a <see cref="LifecycleTagPredicate"/>
        /// </summary>
        /// <param name="lifecycleTagPredicate"></param>
        void Visit(LifecycleTagPredicate lifecycleTagPredicate);

        /// <summary>
        /// Visit a <see cref="LifecycleObjectSizeGreaterThanPredicate"/>
        /// </summary>
        /// <param name="lifecycleGreaterThanPredicate"></param>
        void Visit(LifecycleObjectSizeGreaterThanPredicate lifecycleGreaterThanPredicate);

        /// <summary>
        /// Visit a <see cref="LifecycleObjectSizeLessThanPredicate"/>
        /// </summary>
        /// <param name="lifecycleGreaterLessThanPredicate"></param>
        void Visit(LifecycleObjectSizeLessThanPredicate lifecycleGreaterLessThanPredicate);

        /// <summary>
        /// Visit a <see cref="LifecycleAndOperator"/>
        /// </summary>
        /// <param name="lifecycleAndOperator"></param>
        void Visit(LifecycleAndOperator lifecycleAndOperator);
    }

    /// <summary>
    /// Implementation of <see cref="ILifecyclePredicateVisitor"/> to marshall <see cref="LifecycleFilterPredicate"/>.
    /// </summary>
    internal class LifecycleFilterPredicateMarshallVisitor : ILifecyclePredicateVisitor
    {
        private XmlWriter xmlWriter;

        public LifecycleFilterPredicateMarshallVisitor(XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;
        }

        public void Visit(LifecyclePrefixPredicate lifecyclePrefixPredicate)
        {
            xmlWriter.WriteElementString("Prefix", S3Transforms.ToXmlStringValue(lifecyclePrefixPredicate.Prefix));
        }

        public void Visit(LifecycleTagPredicate lifecycleTagPredicate)
        {
            xmlWriter.WriteStartElement("Tag");
            if (lifecycleTagPredicate.IsSetTag())
            {
                xmlWriter.WriteElementString("Key", S3Transforms.ToXmlStringValue(lifecycleTagPredicate.Tag.Key));
                xmlWriter.WriteElementString("Value", S3Transforms.ToXmlStringValue(lifecycleTagPredicate.Tag.Value));
            }
            xmlWriter.WriteEndElement();
        }

        public void Visit(LifecycleObjectSizeGreaterThanPredicate lifecycleGreaterThanPredicate)
        {
            xmlWriter.WriteElementString("ObjectSizeGreaterThan", S3Transforms.ToXmlStringValue(lifecycleGreaterThanPredicate.ObjectSizeGreaterThan.Value));
        }

        public void Visit(LifecycleObjectSizeLessThanPredicate lifecycleGreaterLessThanPredicate)
        {
            xmlWriter.WriteElementString("ObjectSizeLessThan", S3Transforms.ToXmlStringValue(lifecycleGreaterLessThanPredicate.ObjectSizeLessThan.Value));
        }

        public void Visit(LifecycleAndOperator lifecycleAndOperator)
        {
            xmlWriter.WriteStartElement("And");
            if (lifecycleAndOperator.IsSetOperands())
            {
                foreach (var predicate in lifecycleAndOperator.Operands)
                {
                    if (predicate != null)
                        predicate.Accept(this);
                }
            }
            xmlWriter.WriteEndElement();
        }
    }
}
