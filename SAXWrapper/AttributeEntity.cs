﻿/*
*
* AttributeEntity.cs
*
* Copyright 2016 Yuichi Yoshii
*     吉井雄一 @ 吉井産業  you.65535.kir@gmail.com
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace SAXWrapper {

    public class AttributeEntity {

        #region -- プロパティ --

        private string attrName;

        public void SetAttrName(string arg) {
            attrName = arg;
        }

        public string GetAttrName() {
            return attrName;
        }

        private string attrValue;

        public void SetAttrValue(string arg) {
            attrValue = arg;
        }

        public string GetAttrValue() {
            return attrValue;
        }

        #endregion -- プロパティ --

        public AttributeEntity() {
        }

        #region -- メソッド --

        public bool NameEquals(string arg) {
            if (attrName.Equals(arg)) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool ValueEquals(string arg) {
            if (attrValue.Equals(arg)) {
                return true;
            }
            else {
                return false;
            }
        }

        public AttributeEntity Clone() {
            AttributeEntity ret = new AttributeEntity();
            ret.SetAttrName(attrName);
            ret.SetAttrValue(attrValue);
            return ret;
        }

        #endregion -- メソッド --
    }
}