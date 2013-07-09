/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListPresets operation.
    /// <para>The ListPresets operation gets a list of the default presets included with Elastic Transcoder and the presets that you've added in an
    /// AWS region.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPresets"/>
    public class ListPresetsRequest : AmazonWebServiceRequest
    {
    }
}
    
