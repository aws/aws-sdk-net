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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The source of the container image for an application version: an image that you built
    /// and pushed to a container registry yourself, or settings for Elastic Beanstalk to
    /// build one from your source bundle.
    /// </summary>
    public partial class ImageConfiguration
    {
        private ImageBuildConfiguration _build;
        private ImageSource _source;

        /// <summary>
        /// Gets and sets the property Build. 
        /// <para>
        /// Settings that Elastic Beanstalk uses to build a container image from the source bundle
        /// of the application version.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Build</c>, also specify the request's <c>SourceBundle</c> parameter,
        /// and don't specify <c>Source</c>.
        /// </para>
        /// </summary>
        public ImageBuildConfiguration Build
        {
            get { return this._build; }
            set { this._build = value; }
        }

        // Check to see if Build property is set
        internal bool IsSetBuild()
        {
            return this._build != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The location of a container image that you built and pushed to a container registry
        /// yourself. Elastic Beanstalk deploys the image without a build step.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Source</c>, don't specify <c>Build</c> or the request's <c>SourceBundle</c>
        /// parameter.
        /// </para>
        /// </summary>
        public ImageSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}