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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An invalidation batch.
    /// </summary>
    public partial class InvalidationBatch
    {
        private string _callerReference;
        private Paths _paths;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InvalidationBatch() { }

        /// <summary>
        /// Instantiates InvalidationBatch with the parameterized properties
        /// </summary>
        /// <param name="paths">A complex type that contains information about the objects that you want to invalidate. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html#invalidation-specifying-objects">Specifying the Objects to Invalidate</a> in the <i>Amazon CloudFront Developer Guide</i>.</param>
        /// <param name="callerReference">A value that you specify to uniquely identify an invalidation request. CloudFront uses the value to prevent you from accidentally resubmitting an identical request. Whenever you create a new invalidation request, you must specify a new value for <code>CallerReference</code> and change other values in the request as applicable. One way to ensure that the value of <code>CallerReference</code> is unique is to use a <code>timestamp</code>, for example, <code>20120301090000</code>. If you make a second invalidation request with the same value for <code>CallerReference</code>, and if the rest of the request is the same, CloudFront doesn't create a new invalidation request. Instead, CloudFront returns information about the invalidation request that you previously created with the same <code>CallerReference</code>. If <code>CallerReference</code> is a value you already sent in a previous invalidation batch request but the content of any <code>Path</code> is different from the original request, CloudFront returns an <code>InvalidationBatchAlreadyExists</code> error.</param>
        public InvalidationBatch(Paths paths, string callerReference)
        {
            _paths = paths;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Instantiates InvalidationBatch with the parameterized properties
        /// </summary>
        /// <param name="callerReference">A value that you specify to uniquely identify an invalidation request. CloudFront uses the value to prevent you from accidentally resubmitting an identical request. Whenever you create a new invalidation request, you must specify a new value for <code>CallerReference</code> and change other values in the request as applicable. One way to ensure that the value of <code>CallerReference</code> is unique is to use a <code>timestamp</code>, for example, <code>20120301090000</code>. If you make a second invalidation request with the same value for <code>CallerReference</code>, and if the rest of the request is the same, CloudFront doesn't create a new invalidation request. Instead, CloudFront returns information about the invalidation request that you previously created with the same <code>CallerReference</code>. If <code>CallerReference</code> is a value you already sent in a previous invalidation batch request but the content of any <code>Path</code> is different from the original request, CloudFront returns an <code>InvalidationBatchAlreadyExists</code> error.</param>
        public InvalidationBatch(string callerReference)
        {
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A value that you specify to uniquely identify an invalidation request. CloudFront
        /// uses the value to prevent you from accidentally resubmitting an identical request.
        /// Whenever you create a new invalidation request, you must specify a new value for <code>CallerReference</code>
        /// and change other values in the request as applicable. One way to ensure that the value
        /// of <code>CallerReference</code> is unique is to use a <code>timestamp</code>, for
        /// example, <code>20120301090000</code>.
        /// </para>
        ///  
        /// <para>
        /// If you make a second invalidation request with the same value for <code>CallerReference</code>,
        /// and if the rest of the request is the same, CloudFront doesn't create a new invalidation
        /// request. Instead, CloudFront returns information about the invalidation request that
        /// you previously created with the same <code>CallerReference</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>CallerReference</code> is a value you already sent in a previous invalidation
        /// batch request but the content of any <code>Path</code> is different from the original
        /// request, CloudFront returns an <code>InvalidationBatchAlreadyExists</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// A complex type that contains information about the objects that you want to invalidate.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html#invalidation-specifying-objects">Specifying
        /// the Objects to Invalidate</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Paths Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null;
        }

    }
}