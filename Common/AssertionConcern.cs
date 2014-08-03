//   Copyright 2012,2013 Vaughn Vernon
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.DDS.Common
{
    public class AssertionConcern
    {
        protected AssertionConcern() : base() { }

        protected void AssertArgumentEquals(Object anObject1, Object anObject2, String aMessage)
        {
            if (!anObject1.Equals(anObject2))
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentFalse(bool aBoolean, String aMessage)
        {
            if (aBoolean)
            {
                throw new ArgumentException(aMessage);
            }
        }


        protected void AssertArgumentLength(String aString, int aMaximum, String aMessage)
        {
            int length = aString.Trim().Length;
            if (length > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentLength(String aString, int aMinimum, int aMaximum, String aMessage)
        {
            int length = aString.Trim().Length;
            if (length < aMinimum || length > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentNotEmpty(String aString, String aMessage)
        {
            if (String.IsNullOrEmpty(aString))
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentNotEquals(Object anObject1, Object anObject2, String aMessage)
        {
            if (anObject1.Equals(anObject2))
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentNotNull(Object anObject, String aMessage)
        {
            if (anObject == null)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentRange(double aValue, double aMinimum, double aMaximum, String aMessage)
        {
            if (aValue < aMinimum || aValue > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentRange(float aValue, float aMinimum, float aMaximum, String aMessage)
        {
            if (aValue < aMinimum || aValue > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentRange(int aValue, int aMinimum, int aMaximum, String aMessage)
        {
            if (aValue < aMinimum || aValue > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentRange(long aValue, long aMinimum, long aMaximum, String aMessage)
        {
            if (aValue < aMinimum || aValue > aMaximum)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertArgumentTrue(bool aBoolean, String aMessage)
        {
            if (!aBoolean)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertStateFalse(bool aBoolean, String aMessage)
        {
            if (aBoolean)
            {
                throw new ArgumentException(aMessage);
            }
        }

        protected void AssertStateTrue(bool aBoolean, String aMessage)
        {
            if (!aBoolean)
            {
                throw new ArgumentException(aMessage);
            }
        }

    }
}
