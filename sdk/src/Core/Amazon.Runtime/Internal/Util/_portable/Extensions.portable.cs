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
using System.Reflection;

namespace Amazon.Runtime.Internal.Util
{
    public static partial class Extensions
    {
        public static Type[] GetTypes(this Assembly self)
        {
            List<Type> types = new List<Type>();
            var definedTypes = self.DefinedTypes;
            foreach (var t in definedTypes)
            {
                var type = t.AsType();
                types.Add(type);
            }
            return types.ToArray();
        }

        public static string ToString(this string self, IFormatProvider formatProvider)
        {
            return self;
        }
        public static string ToLower(this string self, IFormatProvider formatProvider)
        {
            return self.ToLower();
        }
        public static string ToUpper(this string self, IFormatProvider formatProvider)
        {
            return self.ToUpper();
        }

        public static string ToString(this bool self, IFormatProvider formatProvider)
        {
            return self.ToString();
        }

        public static string ToString(this char self, IFormatProvider formatProvider)
        {
            return self.ToString();
        }

        public static string ToString(this Guid self, string format, IFormatProvider formatProvider)
        {
            return self.ToString(format);
        }
    }
}
