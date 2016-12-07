/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about a segment annotation.
    /// </summary>
    public partial class ValueWithServiceIds
    {
        private AnnotationValue _annotationValue;
        private List<ServiceId> _serviceIds = new List<ServiceId>();

        /// <summary>
        /// Gets and sets the property AnnotationValue. 
        /// <para>
        /// Values of the annotation.
        /// </para>
        /// </summary>
        public AnnotationValue AnnotationValue
        {
            get { return this._annotationValue; }
            set { this._annotationValue = value; }
        }

        // Check to see if AnnotationValue property is set
        internal bool IsSetAnnotationValue()
        {
            return this._annotationValue != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceIds. 
        /// <para>
        /// Services to which the annotation applies.
        /// </para>
        /// </summary>
        public List<ServiceId> ServiceIds
        {
            get { return this._serviceIds; }
            set { this._serviceIds = value; }
        }

        // Check to see if ServiceIds property is set
        internal bool IsSetServiceIds()
        {
            return this._serviceIds != null && this._serviceIds.Count > 0; 
        }

    }
}