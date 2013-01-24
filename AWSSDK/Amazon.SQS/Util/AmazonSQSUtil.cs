/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-09-15
 */

using System;
using System.Collections.Generic;
using System.Text;

using Attribute = Amazon.SQS.Model.Attribute;

namespace Amazon.SQS.Util
{
    internal static class AmazonSQSUtil
    {
        internal static Attribute FindAttribute(IList<Attribute> attributes, string name)
        {
            foreach (Attribute attr in attributes)
            {
                if (string.Equals(name, attr.Name))
                {
                    return attr;
                }
            }

            return null;
        }
    }
}
