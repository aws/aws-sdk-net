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

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the AddAssociation operation.
    /// Creates an <i>association</i> between the source and the destination. A source can
    /// be associated with multiple destinations, and a destination can be associated with
    /// multiple sources. An association is a lineage tracking entity. For more information,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
    /// SageMaker ML Lineage Tracking</a>.
    /// </summary>
    public partial class AddAssociationRequest : AmazonSageMakerRequest
    {
        private AssociationEdgeType _associationType;
        private string _destinationArn;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association. The following are suggested uses for each type. Amazon SageMaker
        /// places no restrictions on their use.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ContributedTo - The source contributed to the destination or had a part in enabling
        /// the destination. For example, the training data contributed to the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AssociatedWith - The source is connected to the destination. For example, an approval
        /// workflow is associated with a model deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DerivedFrom - The destination is a modification of the source. For example, a digest
        /// output of a channel input for a processing job is derived from the original inputs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Produced - The source generated the destination. For example, a training job produced
        /// a model artifact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssociationEdgeType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}