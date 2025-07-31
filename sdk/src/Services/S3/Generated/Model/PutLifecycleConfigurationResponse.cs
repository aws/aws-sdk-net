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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the PutLifecycleConfiguration operation.
    /// </summary>
    public partial class PutLifecycleConfigurationResponse : AmazonWebServiceResponse
    {
        private TransitionDefaultMinimumObjectSize _transitionDefaultMinimumObjectSize;

        /// <summary>
        /// Gets and sets the property TransitionDefaultMinimumObjectSize. 
        /// <para>
        /// Indicates which default minimum object size behavior is applied to the lifecycle configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>all_storage_classes_128K</c> - Objects smaller than 128 KB will not transition
        /// to any storage class by default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>varies_by_storage_class</c> - Objects smaller than 128 KB will transition to Glacier
        /// Flexible Retrieval or Glacier Deep Archive storage classes. By default, all other
        /// storage classes will prevent transitions smaller than 128 KB. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To customize the minimum object size for any transition you can add a filter that
        /// specifies a custom <c>ObjectSizeGreaterThan</c> or <c>ObjectSizeLessThan</c> in the
        /// body of your transition rule. Custom filters always take precedence over the default
        /// transition behavior.
        /// </para>
        /// </summary>
        public TransitionDefaultMinimumObjectSize TransitionDefaultMinimumObjectSize
        {
            get { return this._transitionDefaultMinimumObjectSize; }
            set { this._transitionDefaultMinimumObjectSize = value; }
        }

        // Check to see if TransitionDefaultMinimumObjectSize property is set
        internal bool IsSetTransitionDefaultMinimumObjectSize()
        {
            return this._transitionDefaultMinimumObjectSize != null;
        }

    }
}