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
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for MetricsAccessPointArnPredicate
    /// <para>The access point arn used when evaluating a metrics filter.</para>
    /// </summary>
    public class MetricsAccessPointArnPredicate : MetricsFilterPredicate
    {
        private string _accessPointArn;

        /// <summary>
        /// Initializes a MetricsAccessPointArnPredicate
        /// </summary>
        /// <param name="accessPointArn">The access point arn used when evaluating a metrics filter.</param>
        public MetricsAccessPointArnPredicate(string accessPointArn)
        {
            this._accessPointArn = accessPointArn;
        }

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The access point arn used when evaluating a metrics filter.
        /// </para>
        /// </summary>
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        internal override void Accept(IMetricsPredicateVisitor metricsPredicateVisitor)
        {
            metricsPredicateVisitor.visit(this);
        }
    }
}