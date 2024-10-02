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
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  GetLifecycleConfiguration response and response metadata.
    /// </summary>
    public class GetLifecycleConfigurationResponse : AmazonWebServiceResponse
    {

        private LifecycleConfiguration configuration;
        private TransitionDefaultMinimumObjectSize _transitionDefaultMinimumObjectSize;
        /// <summary>
        /// Gets and Sets the property that governs whether
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// 
        /// By default this property is false and successful deletes
        /// are returned in the response.
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get 
            {
                if (this.configuration == null)
                    this.configuration = new LifecycleConfiguration();

                return this.configuration; 
            }
            set { this.configuration = value; }
        }

        /// <summary>
        /// Gets and sets the property TransitionDefaultMinimumObjectSize. 
        /// <para>
        /// Indicates which default minimum object size behavior is applied to the lifecycle configuration.
        /// </para>
        ///  <ul> <li> 
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
            return !string.IsNullOrEmpty(this._transitionDefaultMinimumObjectSize);
        }
    }
}
    
